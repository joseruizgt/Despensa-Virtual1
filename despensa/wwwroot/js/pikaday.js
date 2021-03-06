
(function(root, factory) {
	'use strict';

	if (typeof exports === 'object') {
		// CommonJS module
		module.exports = factory();
	} else if (typeof define === 'function' && define.amd) {
		// AMD. Register as an anonymous module.
		define(factory);
	} else {
		root.Pikaday = factory();
	}
})(this, function() {
	'use strict';

	var EvEmitter = (function() {
		function EvEmitter() {}

		var proto = EvEmitter.prototype;

		proto.on = function(eventName, listener) {
			if (!eventName || !listener) {
				return;
			}
			// set events hash
			var events = (this._events = this._events || {});
			// set listeners array
			var listeners = (events[eventName] = events[eventName] || []);
			// only add once
			if (listeners.indexOf(listener) == -1) {
				listeners.push(listener);
			}

			return this;
		};

		proto.once = function(eventName, listener) {
			if (!eventName || !listener) {
				return;
			}
			// add event
			this.on(eventName, listener);
			// set once flag
			// set onceEvents hash
			var onceEvents = (this._onceEvents = this._onceEvents || {});
			// set onceListeners object
			var onceListeners = (onceEvents[eventName] = onceEvents[eventName] || {});
			// set flag
			onceListeners[listener] = true;

			return this;
		};

		proto.off = function(eventName, listener) {
			if (typeof eventName === 'undefined') {
				delete this._events;
				delete this._onceEvents;
				return;
			}
			var listeners = this._events && this._events[eventName];
			if (!listeners || !listeners.length) {
				return;
			}
			var index = listeners.indexOf(listener);
			if (index != -1) {
				listeners.splice(index, 1);
			}

			return this;
		};

		proto.emitEvent = function(eventName, args) {
			var listeners = this._events && this._events[eventName];
			if (!listeners || !listeners.length) {
				return;
			}
			var i = 0;
			var listener = listeners[i];
			args = args || [];
			// once stuff
			var onceListeners = this._onceEvents && this._onceEvents[eventName];

			while (listener) {
				var isOnce = onceListeners && onceListeners[listener];
				if (isOnce) {
					// remove listener
					// remove before trigger to prevent recursion
					this.off(eventName, listener);
					// unset once flag
					delete onceListeners[listener];
				}
				// trigger listener
				listener.apply(this, args);
				// get next listener
				i += isOnce ? 0 : 1;
				listener = listeners[i];
			}

			return this;
		};

		return EvEmitter;
	})();

	/**
	 * feature detection and helper functions
	 */

	var log = function() {
		// console.log.apply ? console.log.apply(console, arguments) : console.log(arguments);
	};

	var hasEventListeners = !!window.addEventListener,
		document = window.document,
		sto = window.setTimeout,
		requestAnimationFrame = function(cb) {
			if (window.requestAnimationFrame) {
				return window.requestAnimationFrame(cb);
			} else {
				return setTimeout(cb, 1);
			}
		},
		cancelAnimationFrame = function(id) {
			if (window.requestAnimationFrame) {
				return window.cancelAnimationFrame(id);
			} else {
				return clearTimeout(id);
			}
		},
		addEvent = function(el, e, callback, capture) {
			if (hasEventListeners) {
				el.addEventListener(e, callback, !!capture);
			} else {
				el.attachEvent('on' + e, callback);
			}
		},
		removeEvent = function(el, e, callback, capture) {
			if (hasEventListeners) {
				el.removeEventListener(e, callback, !!capture);
			} else {
				el.detachEvent('on' + e, callback);
			}
		},
		fireEvent = function(el, eventName, data) {
			var ev;

			if (document.createEvent) {
				ev = document.createEvent('HTMLEvents');
				ev.initEvent(eventName, true, false);
				ev = extend(ev, data);
				el.dispatchEvent(ev);
			} else if (document.createEventObject) {
				ev = document.createEventObject();
				ev = extend(ev, data);
				el.fireEvent('on' + eventName, ev);
			}
		},
		trim = function(str) {
			return str.trim ? str.trim() : str.replace(/^\s+|\s+$/g, '');
		},
		hasClass = function(el, cn) {
			if (!el) return null;
			return (' ' + el.className + ' ').indexOf(' ' + cn + ' ') !== -1;
		},
		addClass = function(el, cn) {
			if (el && !hasClass(el, cn)) {
				el.className = el.className === '' ? cn : el.className + ' ' + cn;
			}
		},
		removeClass = function(el, cn) {
			if (!el) return false;
			el.className = trim((' ' + el.className + ' ').replace(' ' + cn + ' ', ' '));
		},
		isArray = function(obj) {
			return /Array/.test(Object.prototype.toString.call(obj));
		},
		isDate = function(obj) {
			return /Date/.test(Object.prototype.toString.call(obj)) && !isNaN(obj.getTime());
		},
		isWeekend = function(date) {
			var day = date.getDay();
			return day === 0 || day === 6;
		},
		isLeapYear = function(year) {
			return (year % 4 === 0 && year % 100 !== 0) || year % 400 === 0;
		},
		getDaysInMonth = function(year, month) {
			return [31, isLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31][month];
		},
		setToStartOfDay = function(date) {
			if (isDate(date)) date.setHours(0, 0, 0, 0);
		},
		areDatesEqual = function(a, b) {
			if (a == b) {
				return true;
			}
			if (!a || !b) {
				return false;
			}
			// weak date comparison (use setToStartOfDay(date) to ensure correct result)
			return a.getTime() === b.getTime();
		},
		toISODateString = function(date) {
			var y = date.getFullYear(),
				m = String(date.getMonth() + 1),
				d = String(date.getDate());
			return y + '-' + (m.length == 1 ? '0' : '') + m + '-' + (d.length == 1 ? '0' : '') + d;
		},
		extend = function(to, from, overwrite) {
			var prop, hasProp;
			for (prop in from) {
				hasProp = to[prop] !== undefined;
				if (
					hasProp &&
					typeof from[prop] === 'object' &&
					from[prop] !== null &&
					from[prop].nodeName === undefined
				) {
					if (isDate(from[prop])) {
						if (overwrite) {
							to[prop] = new Date(from[prop].getTime());
						}
					} else if (isArray(from[prop])) {
						if (overwrite) {
							to[prop] = from[prop].slice(0);
						}
					} else {
						to[prop] = extend({}, from[prop], overwrite);
					}
				} else if (overwrite || !hasProp) {
					to[prop] = from[prop];
				}
			}
			return to;
		},
		adjustCalendar = function(calendar) {
			if (calendar.month < 0) {
				calendar.year -= Math.ceil(Math.abs(calendar.month) / 12);
				calendar.month += 12;
			}
			if (calendar.month > 11) {
				calendar.year += Math.floor(Math.abs(calendar.month) / 12);
				calendar.month -= 12;
			}
			return calendar;
		},
		containsElement = function(container, element) {
			while (element) {
				if (container === element) {
					return true;
				}
				element = element.parentNode;
			}
			return false;
		},
		/**
		 * defaults and localisation
		 */
		defaults = {
			// initialise right away, if false, you have to call new Pikaday(options).init();
			autoInit: true,

			// bind the picker to a form field
			field: null,

			// default `field` if `field` is set
			trigger: null,

			// automatically show/hide the picker on `field` focus (default `true` if `field` is set)
			bound: undefined,

			// position of the datepicker, relative to the field (default to bottom & left)
			// ('bottom' & 'left' keywords are not used, 'top' & 'right' are modifier on the bottom/left position)
			positionTarget: null,
			position: 'bottom left',

			// automatically fit in the viewport even if it means repositioning from the position option
			reposition: true,

			// the default output format for `.toString()` and `field` value
			// a function(date) { return string }
			// could be date.toLocaleDateString(this._options.i18n.language, {year: 'numeric', month: 'short', day: 'numeric', weekday: 'short'})
			formatFn: function(date) {
				return toISODateString(date);
			},

			parseFn: function(value) {
				return new Date(Date.parse(value));
			},

			// the initial date to view when first opened
			defaultDate: null,

			// make the `defaultDate` the initial selected value
			setDefaultDate: false,

			// first day of week (0: Sunday, 1: Monday etc)
			firstDay: 0,

			disableDayFn: null,

			labelFn: function(day) {
				if (!this.dateFormatter) {
					try {
						this.dateFormatter = window.Intl.DateTimeFormat(
							this._options.i18n.language,
							{
								year: 'numeric',
								month: 'long',
								day: 'numeric'
							}
						);
					} catch (e) {
						this.dateFormatter = {
							format: function(date) {
								return date.toDateString();
							}
						};
					}
				}
				var dateStr = this.dateFormatter.format(day.date);
				var dayStr = this._options.i18n.weekdays[day.date.getDay()];
				var text = dayStr + ', ' + dateStr;
				if (day.isToday) {
					text += ' (' + this._options.i18n.today + ')';
				}
				if (day.isDisabled) {
					text = '(' + this._options.i18n.disabled + ') ' + text;
				}
				return text;
			},

			dayFn: function(day) {
				return day;
			},

			renderFn: function(day) {
				return {}; // text, label, style
			},

			// the minimum/earliest date that can be selected
			minDate: null,
			// the maximum/latest date that can be selected
			maxDate: null,

			// number of years either side, or array of upper/lower range
			yearRange: 10,

			// show week numbers at head of row
			showWeekNumber: false,

			// used internally (don't config outside)
			minYear: 0,
			maxYear: 9999,
			minMonth: undefined,
			maxMonth: undefined,

			startRange: null,
			endRange: null,

			isRTL: false,

			// Additional text to append to the year in the calendar title
			yearSuffix: '',

			// Render the month after year in the calendar title
			showMonthAfterYear: false,

			// Render days of the calendar grid that fall in the next or previous month
			showDaysInNextAndPreviousMonths: false,

			// how many months are visible
			numberOfMonths: 1,

			// when numberOfMonths is used, this will help you to choose where the main calendar will be (default `left`, can be set to `right`)
			// only used for the first display or when a selected date is not visible
			mainCalendar: 'left',

			// Specify a DOM element to render the calendar in
			container: undefined,

			// internationalization
			i18n: {
				language: document.querySelector('html').getAttribute('lang') || undefined,
				today: 'Hoy',
				disabled: 'Desactivar',
				help: 'Use las teclas de flecha para elegir una fecha.',

				previousMonth: 'Anterior',
				nextMonth: 'Siguiente',
				months: [
					'Enero',
					'Febrero',
					'Marzo',
					'Abril',
					'Mayo',
					'Junio',
					'Julio',
					'Agosto',
					'Septiembre',
					'Octubre',
					'Noviembre',
					'Diciembre'
				],
				weekdays: [
					'Lunes',
					'Martes',
					'Muercoles',
					'Jueves',
					'Viernes',
					'Sabado',
					'Domingo'
				],
				weekdaysShort: ['lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab', 'Dom']
			},

			// Theme Classname
			theme: null,

			// callback function
			onSelect: null,
			onOpen: null,
			onClose: null,
			onDraw: null
		},
		/**
		 * templating functions to abstract HTML rendering
		 */
		renderDayName = function(opts, day, abbr) {
			day += opts.firstDay;
			while (day >= 7) {
				day -= 7;
			}
			return abbr ? opts.i18n.weekdaysShort[day] : opts.i18n.weekdays[day];
		},
		renderDay = function(opts) {
			var arr = [];
			var ariaSelected = 'false';
			var ariaLabel = opts.label || '';
			var tabindex = opts.tabindex;
			if (opts.isEmpty) {
				if (opts.showDaysInNextAndPreviousMonths) {
					arr.push('is-outside-current-month');
				} else {
					return '<td class="is-empty"></td>';
				}
			}
			if (opts.isDisabled) {
				arr.push('is-disabled');
			}
			if (opts.isToday) {
				arr.push('is-today');
			}
			if (opts.isSelected) {
				arr.push('is-selected');
				ariaSelected = 'true';
			}
			if (opts.isInRange) {
				arr.push('is-inrange');
			}
			if (opts.isStartRange) {
				arr.push('is-startrange');
			}
			if (opts.isEndRange) {
				arr.push('is-endrange');
			}
			if (opts.classes) {
				arr.push(opts.classes);
			}

			var html = '',
				attr,
				key;

			attr = {
				class: arr.join(' '),
				'data-day': opts.day
			};
			for (key in opts.td) {
				attr[key] = opts.td[key];
			}

			html += '<td';
			for (key in attr) {
				html += ' ' + key + '="' + attr[key] + '"';
			}
			html += '>';

			attr = {
				class: 'pika-button pika-day',
				type: 'button',
				'data-pika-year': opts.year,
				'data-pika-month': opts.month,
				'data-pika-day': opts.day,
				'aria-selected': ariaSelected,
				'aria-label': ariaLabel,
				tabindex: tabindex
			};
			for (key in opts.button) {
				attr[key] = opts.button[key];
			}
			html += '<button';
			for (key in attr) {
				html += ' ' + key + '="' + attr[key] + '"';
			}
			html += '>' + opts.text + '</button>';
			html += '</td>';
			return html;
		},
		renderWeek = function(d, m, y) {
			var onejan = new Date(y, 0, 1),
				weekNum = Math.ceil(
					((new Date(y, m, d) - onejan) / 86400000 + onejan.getDay() + 1) / 7
				);
			return '<td class="pika-week">' + weekNum + '</td>';
		},
		renderRow = function(days, isRTL) {
			return '<tr>' + (isRTL ? days.reverse() : days).join('') + '</tr>';
		},
		renderBody = function(rows) {
			return '<tbody>' + rows.join('') + '</tbody>';
		},
		renderHead = function(opts) {
			var i,
				arr = [];
			if (opts.showWeekNumber) {
				arr.push('<th></th>');
			}
			for (i = 0; i < 7; i++) {
				arr.push(
					'<th scope="col"><abbr title="' +
						renderDayName(opts, i) +
						'">' +
						renderDayName(opts, i, true) +
						'</abbr></th>'
				);
			}
			return (
				'<thead aria-hidden="true"><tr>' +
				(opts.isRTL ? arr.reverse() : arr).join('') +
				'</tr></thead>'
			);
		},
		renderTitle = function(instance, c, year, month, refYear, randId) {
			var i,
				j,
				arr,
				opts = instance._options,
				isMinYear = year === opts.minYear,
				isMaxYear = year === opts.maxYear,
				html = '<div class="pika-title" aria-hidden="true">',
				monthHtml,
				yearHtml,
				prev = true,
				next = true;

			for (arr = [], i = 0; i < 12; i++) {
				arr.push(
					'<option value="' +
						(year === refYear ? i - c : 12 + i - c) +
						'"' +
						(i === month ? ' selected="selected"' : '') +
						((isMinYear && i < opts.minMonth) || (isMaxYear && i > opts.maxMonth)
							? 'disabled="disabled"'
							: '') +
						'>' +
						opts.i18n.months[i] +
						'</option>'
				);
			}

			monthHtml =
				'<div class="pika-label">' +
				opts.i18n.months[month] +
				'<select class="pika-select pika-select-month" tabindex="-1">' +
				arr.join('') +
				'</select></div>';

			if (isArray(opts.yearRange)) {
				i = opts.yearRange[0];
				j = opts.yearRange[1] + 1;
			} else {
				i = year - opts.yearRange;
				j = 1 + year + opts.yearRange;
			}

			for (arr = []; i < j && i <= opts.maxYear; i++) {
				if (i >= opts.minYear) {
					arr.push(
						'<option value="' +
							i +
							'"' +
							(i === year ? ' selected="selected"' : '') +
							'>' +
							i +
							'</option>'
					);
				}
			}
			yearHtml =
				'<div class="pika-label">' +
				year +
				opts.yearSuffix +
				'<select class="pika-select pika-select-year" tabindex="-1">' +
				arr.join('') +
				'</select></div>';

			if (opts.showMonthAfterYear) {
				html += yearHtml + monthHtml;
			} else {
				html += monthHtml + yearHtml;
			}

			if (isMinYear && (month === 0 || opts.minMonth >= month)) {
				prev = false;
			}

			if (isMaxYear && (month === 11 || opts.maxMonth <= month)) {
				next = false;
			}

			if (c === 0) {
				html +=
					'<button class="pika-prev' +
					(prev ? '' : ' is-disabled') +
					'" ' +
					(prev ? '' : 'disabled ') +
					'type="button" aria-labelledby="' +
					randId +
					'" tabindex="-1">' +
					opts.i18n.previousMonth +
					'</button>';
			}
			if (c === instance._options.numberOfMonths - 1) {
				html +=
					'<button class="pika-next' +
					(next ? '' : ' is-disabled') +
					'" ' +
					(next ? '' : 'disabled ') +
					'type="button" aria-labelledby="' +
					randId +
					'" tabindex="-1">' +
					opts.i18n.nextMonth +
					'</button>';
			}

			return (html += '</div>');
		},
		renderTable = function(opts, data, randId) {
			return (
				'<table cellpadding="0" cellspacing="0" class="pika-table" role="presentation">' +
				renderHead(opts) +
				renderBody(data) +
				'</table>'
			);
		},
		/**
		 * Pikaday constructor
		 */
		Pikaday = function(options) {
			var self = this,
				opts = self.config(options);

			self.defaults = defaults;

			// backwards compatibility

			Object.defineProperty(this, '_d', {
				get: function() {
					return self._date;
				},
				set: function(value) {
					self._date = value;
				}
			});
			Object.defineProperty(this, '_o', {
				get: function() {
					return self._options;
				},
				set: function(value) {
					self._options = value;
				}
			});

			self._onClick = function(e) {
				if (!self._visible) {
					return;
				}
				e = e || window.event;
				var target = e.target || e.srcElement;
				if (!target) {
					return;
				}

				e.stopPropagation();

				if (!hasClass(target, 'is-disabled')) {
					if (
						hasClass(target, 'pika-button') &&
						!hasClass(target, 'is-empty') &&
						!hasClass(target.parentNode, 'is-disabled')
					) {
						if (opts.bound) {
							this._visible &&
								log(
									'Hiding soon because date has been selected and picker is bound.'
								);
							self.hideAfter(200);
						}
						self.setDate(
							new Date(
								target.getAttribute('data-pika-year'),
								target.getAttribute('data-pika-month'),
								target.getAttribute('data-pika-day')
							)
						);
					} else if (hasClass(target, 'pika-prev')) {
						self.prevMonth();
					} else if (hasClass(target, 'pika-next')) {
						self.nextMonth();
					}
				}
				if (!hasClass(target, 'pika-select')) {
					// if this is touch event prevent mouse events emulation
					if (e.preventDefault) {
						e.preventDefault();
					} else {
						e.returnValue = false;
						return false;
					}
				} else {
					self._clickedPikaSelect = true;
				}
			};

			self._onChange = function(e) {
				e = e || window.event;
				var target = e.target || e.srcElement;
				if (!target) {
					return;
				}
				if (hasClass(target, 'pika-select-month')) {
					self.gotoMonth(target.value);
				} else if (hasClass(target, 'pika-select-year')) {
					self.gotoYear(target.value);
				}
			};

			self._onKeyChange = function(e) {
				e = e || window.event;

				// once user start key navigation, we'll handle some things differently
				// (like setting the focus into the picker)
				function captureKey() {
					self.hasKey = true;
					self.focusInside = true;
					stopEvent();
				}
				// a gui component should stop propagation of action keys
				// (compare to select)
				function stopEvent() {
					e.preventDefault();
					e.stopPropagation();
				}

				if (self.isVisible()) {
					switch (e.keyCode) {
						case 9 /* TAB */:
							if (self.hasKey && self._options.trigger && self._options.bound) {
								self._options.trigger.focus();
								self.hasKey = false;
							}
							break;
						case 32: /* SPACE */
						case 13 /* ENTER */:
							if (self.hasKey && opts.bound) {
								stopEvent();
								if (self._options.trigger) {
									self._options.trigger.focus();
									try {
										self._options.trigger.select();
									} catch (e) {} // trigger could be a button
								}
								self.emitEvent('select', [self.getDate()]);
								log('Hiding because enter or space pressed');
								self.hide();
							} else {
								self.emitEvent('select', [self.getDate()]);
							}
							break;
						case 27 /* ESCAPE */:
							if (opts.bound) {
								stopEvent();
								log('Cancel because escape pressed');
								self.cancel();
							}
							break;
						case 37 /* LEFT */:
							captureKey();
							self.adjustDate(-1);
							break;
						case 38 /* UP */:
							captureKey();
							self.adjustDate(-7);
							break;
						case 39 /* RIGHT */:
							captureKey();
							self.adjustDate(+1);
							break;
						case 40 /* DOWN */:
							captureKey();
							self.adjustDate(+7);
							break;
						case 33 /* PAGE_UP */:
							captureKey();
							self.adjustMonth(-1);
							break;
						case 34 /* PAGE_DOWN */:
							captureKey();
							self.adjustMonth(+1);
							break;
						case 35 /* END */:
							captureKey();
							self.adjustYear(+1);
							break;
						case 36 /* HOME */:
							captureKey();
							self.adjustYear(-1);
							break;
					}
				}
			};

			self._onInputChange = function(e) {
				var date;

				if (e.firedBy === self) {
					return;
				}
				date = opts.parseFn.call(self, opts.field.value);
				if (isDate(date)) {
					self.setDate(date, true);
				} else {
					self.setDate(null, true);
				}
			};

			self._onTouch = function(event) {
				if (!self.isVisible() || event.target !== opts.field) {
					self.touched = true;
				}
			};

			self._onInputFocus = function(event) {
				if (self.touched && opts.field && opts.field.nodeName === 'INPUT') {
					self.touched = false;
					self.focusInside = true;
					opts.field.blur();
				}
				log('Showing because input was focused', event.target);
				self.show();
			};

			self._onInputClick = function(event) {
				if (self.touched) {
					self._options.trigger.focus(); // because iOS wouldn't do
				}
				self.touched = false;
				log('Showing because input was clicked', event.target);
				self.show();
			};

			self._onInputBlur = function(event) {
				if (self.hasKey) {
					return;
				}
				if (self.focusInside) {
					return;
				}
				requestAnimationFrame(function() {
					// IE allows pika div to gain focus; catch blur the input field
					var pEl = document.activeElement;
					do {
						if (hasClass(pEl, 'pika-single') || pEl == self.el) {
							return;
						}
					} while ((pEl = pEl.parentNode));

					if (!self._clickedPikaSelect) {
						self._visible &&
							log('Hiding soon because input was blured', event.target, self._b);
						self.hide(true);
					}
					self._clickedPikaSelect = false;
				});
			};

			self._onDocumentClick = function(e) {
				e = e || window.event;
				var target = e.target || e.srcElement,
					pEl = target;
				if (!target) {
					return;
				}
				var timeSinceShown = new Date() - self.timeShowed;
				if (timeSinceShown < 200) {
					return;
				}
				if (containsElement(self.el, target)) {
					return;
				}
				if (!hasEventListeners && hasClass(target, 'pika-select')) {
					if (!target.onchange) {
						target.setAttribute('onchange', 'return;');
						addEvent(target, 'change', self._onChange);
					}
				}
				do {
					if (hasClass(pEl, 'pika-single') || pEl === opts.trigger) {
						return;
					}
				} while ((pEl = pEl.parentNode));
				if (self._visible && target !== opts.trigger && pEl !== opts.trigger) {
					log('Hiding because of document click');
					self.hide(true);
				}
			};

			self.init = function() {
				this._visible = false; // visibility

				self.el = document.createElement('div');
				self.el.className =
					'pika-single' +
					(opts.isRTL ? ' is-rtl' : '') +
					(opts.theme ? ' ' + opts.theme : '');
				self.el.setAttribute('role', 'application');
				self.el.setAttribute('aria-label', self.getLabel());

				self.speakEl = document.createElement('div');
				self.speakEl.setAttribute('role', 'status');
				self.speakEl.setAttribute('aria-live', 'assertive');
				self.speakEl.setAttribute('aria-atomic', 'true');
				self.speakEl.setAttribute(
					'style',
					'position: absolute; left: -9999px; opacity: 0;'
				);

				addEvent(self.el, 'mousedown', self._onClick, true);
				addEvent(self.el, 'touchend', self._onClick, true);
				addEvent(self.el, 'change', self._onChange);
				addEvent(self.el, 'keydown', self._onKeyChange);

				if (opts.field) {
					addEvent(opts.field, 'change', self._onInputChange);

					if (!opts.defaultDate) {
						opts.defaultDate = opts.parseFn.call(self, opts.field.value);
						opts.setDefaultDate = true;
					}
				}

				var defDate = opts.defaultDate;

				if (isDate(defDate)) {
					if (opts.setDefaultDate) {
						self.setDate(defDate, true);
					} else {
						self.gotoDate(defDate);
					}
				} else {
					defDate = new Date();
					if (opts.minDate && opts.minDate > defDate) {
						defDate = opts.minDate;
					} else if (opts.maxDate && opts.maxDate < defDate) {
						defDate = opts.maxDate;
					}
					self.gotoDate(defDate);
				}

				if (opts.bound) {
					log('Hiding initially');
					this.hide();
					self.el.className += ' is-bound';
					addEvent(opts.trigger, 'click', self._onInputClick);
					addEvent(document, 'touchstart', self._onTouch, { passive: true });
					addEvent(opts.trigger, 'focus', self._onInputFocus);
					addEvent(opts.trigger, 'blur', self._onInputBlur);
					addEvent(opts.trigger, 'keydown', self._onKeyChange);
				} else {
					log('Showing initially');
					this.show();
				}

				this.emitEvent('init');
			};

			if (opts.autoInit) {
				this.init();
			}
		};

	Pikaday.util = {
		addClass: addClass,
		addEvent: addEvent,
		adjustCalendar: adjustCalendar,
		areDatesEqual: areDatesEqual,
		containsElement: containsElement,
		defaults: defaults,
		extend: extend,
		fireEvent: fireEvent,
		getDaysInMonth: getDaysInMonth,
		hasClass: hasClass,
		isArray: isArray,
		isDate: isDate,
		isLeapYear: isLeapYear,
		isWeekend: isWeekend,
		log: log,
		removeClass: removeClass,
		removeEvent: removeEvent,
		setToStartOfDay: setToStartOfDay,
		toISODateString: toISODateString,
		trim: trim
	};

	Pikaday.EvEmitter = EvEmitter;

	var now = new Date();
	setToStartOfDay(now);

	/**
	 * public Pikaday API
	 */

	Pikaday.prototype = {
		/**
		 * configure functionality
		 */
		config: function(options) {
			if (!this._options) {
				this._options = extend({}, defaults, true);
			}

			var opts = extend(this._options, options, true);

			opts.isRTL = !!opts.isRTL;

			opts.field = opts.field && opts.field.nodeName ? opts.field : null;

			opts.theme = typeof opts.theme === 'string' && opts.theme ? opts.theme : null;

			opts.bound = !!(opts.bound !== undefined ? opts.field && opts.bound : opts.field);

			opts.trigger = opts.trigger && opts.trigger.nodeName ? opts.trigger : opts.field;

			opts.disableWeekends = !!opts.disableWeekends;

			opts.disableDayFn = typeof opts.disableDayFn === 'function' ? opts.disableDayFn : null;

			opts.labelFn = typeof opts.labelFn === 'function' ? opts.labelFn : null;

			var nom = parseInt(opts.numberOfMonths, 10) || 1;
			opts.numberOfMonths = nom > 4 ? 4 : nom;

			opts.minDate = opts.parseFn.call(self, opts.minDate);
			opts.maxDate = opts.parseFn.call(self, opts.maxDate);
			if (!isDate(opts.minDate)) {
				opts.minDate = false;
			}
			if (!isDate(opts.maxDate)) {
				opts.maxDate = false;
			}
			if (opts.minDate && opts.maxDate && opts.maxDate < opts.minDate) {
				opts.maxDate = opts.minDate = false;
			}
			if (opts.minDate) {
				this.setMinDate(opts.minDate);
			}
			if (opts.maxDate) {
				this.setMaxDate(opts.maxDate);
			}

			if (isArray(opts.yearRange)) {
				var fallback = new Date().getFullYear() - 10;
				opts.yearRange[0] = parseInt(opts.yearRange[0], 10) || fallback;
				opts.yearRange[1] = parseInt(opts.yearRange[1], 10) || fallback;
			} else {
				opts.yearRange = Math.abs(parseInt(opts.yearRange, 10)) || defaults.yearRange;
				if (opts.yearRange > 100) {
					opts.yearRange = 100;
				}
			}

			// listen to "event" when key is onEvent
			var eventTest = /^on([A-Z]\w+)$/;
			Object.keys(opts).forEach(
				function(key) {
					var match = key.match(eventTest);
					if (match) {
						var type = match[1].toLowerCase();
						this.on(type, opts[key]);
						delete opts[key];
					}
				}.bind(this)
			);

			return opts;
		},

		/**
		 * return a formatted string of the current selection
		 */
		toString: function() {
			if (!isDate(this._date)) {
				return '';
			}
			if (typeof this._options.formatFn == 'function') {
				return this._options.formatFn.call(this, this._date);
			}
			return this._date.toDateString();
		},

		/**
		 * return a Date object of the current selection with fallback for the current date
		 */
		getDate: function() {
			return isDate(this._date) ? new Date(this._date.getTime()) : new Date();
		},

		/**
		 * return a Date object of the current selection
		 */
		getSelectedDate: function() {
			return isDate(this._date) ? new Date(this._date.getTime()) : null;
		},

		/**
		 * return a Date object of the current selection
		 */
		getVisibleDate: function() {
			return new Date(this.calendars[0].year, this.calendars[0].month, 1);
		},

		/**
		 * set the current selection
		 */
		setDate: function(date, preventOnSelect) {
			if (!date) {
				this._date = null;

				this.setField('');

				this.emitEvent('change', [this._date]);

				return this.draw();
			}
			if (typeof date === 'string') {
				date = new Date(Date.parse(date));
			}
			if (!isDate(date)) {
				return;
			}

			setToStartOfDay(date);

			var min = this._options.minDate,
				max = this._options.maxDate;

			if (isDate(min) && date < min) {
				date = min;
			} else if (isDate(max) && date > max) {
				date = max;
			}

			if (areDatesEqual(this._date, date)) {
				return;
			}

			this._date = new Date(date.getTime());
			setToStartOfDay(this._date);
			this.gotoDate(this._date);

			this.setField(this.toString());

			if (!preventOnSelect) {
				this.emitEvent('select', [this.getDate()]);
			}
			this.emitEvent('change', [this._date]);
		},

		setField: function(value) {
			var field = this._options.field;
			if (field && value !== field.value) {
				field.value = value;
				fireEvent(field, 'change', { firedBy: this });
				return true;
			} else {
				return false;
			}
		},

		selectDate: function(date, preventOnSelect) {
			this.setDate(date, preventOnSelect);
			if (this._date) {
				this.speak(this.getDayConfig(this._date).label);
			}
		},

		getLabel: function() {
			var label = '',
				opts = this._options;
			if (opts.field && opts.field.id) {
				label = document.querySelector('label[for="' + opts.field.id + '"]');
				label = label ? label.textContent || label.innerText : '';
			}
			if (!label && opts.trigger) {
				label = opts.trigger.textContent || opts.trigger.innerText;
			}
			label += ' (' + opts.i18n.help + ')';
			return label;
		},

		speak: function(html) {
			this.speak.innerHTML = '';
			this.speakEl.innerHTML = html;
		},

		/**
		 * change view to a specific date
		 */
		gotoDate: function(date) {
			var newCalendar = true;

			if (!isDate(date)) {
				return;
			}

			if (this.calendars) {
				var firstVisibleDate = new Date(this.calendars[0].year, this.calendars[0].month, 1),
					lastVisibleDate = new Date(
						this.calendars[this.calendars.length - 1].year,
						this.calendars[this.calendars.length - 1].month,
						1
					),
					visibleDate = date.getTime();
				// get the end of the month
				lastVisibleDate.setMonth(lastVisibleDate.getMonth() + 1);
				lastVisibleDate.setDate(lastVisibleDate.getDate() - 1);
				newCalendar =
					visibleDate < firstVisibleDate.getTime() ||
					lastVisibleDate.getTime() < visibleDate;
			}

			if (newCalendar) {
				this.calendars = [
					{
						month: date.getMonth(),
						year: date.getFullYear()
					}
				];
				if (this._options.mainCalendar === 'right') {
					this.calendars[0].month += 1 - this._options.numberOfMonths;
				}
			}

			this.adjustCalendars();
		},

		adjustDate: function(days) {
			var day = this.getDate();
			var difference = parseInt(days);
			var newDay = new Date(day.valueOf());
			newDay.setDate(newDay.getDate() + difference);
			this.selectDate(newDay, true);
		},

		adjustCalendars: function() {
			this.calendars[0] = adjustCalendar(this.calendars[0]);
			for (var c = 1; c < this._options.numberOfMonths; c++) {
				this.calendars[c] = adjustCalendar({
					month: this.calendars[0].month + c,
					year: this.calendars[0].year
				});
			}
			this.draw();
		},

		gotoToday: function() {
			this.gotoDate(new Date());
		},

		/**
		 * change view to a specific month (zero-index, e.g. 0: January)
		 */
		gotoMonth: function(month) {
			if (!isNaN(month)) {
				this.calendars[0].month = parseInt(month, 10);
				this.adjustCalendars();
			}
		},

		nextMonth: function() {
			this.calendars[0].month++;
			this.adjustCalendars();
		},

		prevMonth: function() {
			this.calendars[0].month--;
			this.adjustCalendars();
		},

		/**
		 * change view to a specific full year (e.g. "2012")
		 */
		gotoYear: function(year) {
			if (!isNaN(year)) {
				this.calendars[0].year = parseInt(year, 10);
				this.adjustCalendars();
			}
		},

		/**
		 * change the minDate
		 */
		setMinDate: function(value) {
			var d = this._options.parseFn.call(self, value);
			if (isDate(d)) {
				// d.getTime() === NaN if date is invalid
				setToStartOfDay(d);
				this._options.minDate = d;
				this._options.minYear = d.getFullYear();
				this._options.minMonth = d.getMonth();
			} else {
				this._options.minDate = defaults.minDate;
				this._options.minYear = defaults.minYear;
				this._options.minMonth = defaults.minMonth;
			}

			this.draw();
		},

		/**
		 * change the maxDate
		 */
		setMaxDate: function(value) {
			var d = this._options.parseFn.call(self, value);
			if (isDate(d)) {
				// d.getTime() === NaN if date is invalid
				setToStartOfDay(d);
				this._options.maxDate = d;
				this._options.maxYear = d.getFullYear();
				this._options.maxMonth = d.getMonth();
			} else {
				this._options.maxDate = defaults.maxDate;
				this._options.maxYear = defaults.maxYear;
				this._options.maxMonth = defaults.maxMonth;
			}

			this.draw();
		},

		setStartRange: function(value) {
			if (!areDatesEqual(this._options.startRange, value)) {
				this._options.startRange = value;
				this.draw();
				this.emitEvent('startrange', [this._options.startRange]);
			}
		},

		setEndRange: function(value) {
			if (!areDatesEqual(this._options.endRange, value)) {
				this._options.endRange = value;
				this.draw();
				this.emitEvent('endrange', [this._options.endRange]);
			}
		},

		getStartRange: function(value) {
			return this._options.startRange;
		},

		getEndRange: function(value) {
			return this._options.endRange;
		},

		_request: function(action) {
			var self = this;
			if (!this.requested) {
				this.requested = {
					request: requestAnimationFrame(function() {
						if (self.requested.draw) {
							self._draw();
						}
						if (self.requested.adjustPosition) {
							self._adjustPosition();
						}
						self.focusPicker();
						self.requested = null;
					})
				};
			}
			this.requested[action] = true;
		},

		/**
		 * request refreshing HTML
		 * (uses requestAnimationFrame if available to improve performance)
		 */
		draw: function(force) {
			if (!this._visible) {
				return; // no need to draw when not visible
			}
			if (force) {
				this._draw(force);
			} else {
				this._request('draw');
			}
		},

		/**
		 * refresh the HTML
		 */
		_draw: function(force) {
			if (!this._visible && !force) {
				return;
			}
			var opts = this._options,
				self = this,
				minYear = opts.minYear,
				maxYear = opts.maxYear,
				minMonth = opts.minMonth,
				maxMonth = opts.maxMonth,
				html = '',
				randId;

			if (this._y <= minYear) {
				this._y = minYear;
				if (!isNaN(minMonth) && this._m < minMonth) {
					this._m = minMonth;
				}
			}
			if (this._y >= maxYear) {
				this._y = maxYear;
				if (!isNaN(maxMonth) && this._m > maxMonth) {
					this._m = maxMonth;
				}
			}

			randId =
				'pika-title-' +
				Math.random()
					.toString(36)
					.replace(/[^a-z]+/g, '')
					.substr(0, 2);

			var label = this.getLabel();

			if (this._options.field && this._options.trigger == this._options.field && opts.bound) {
				this._options.field.setAttribute('aria-label', label);
			}

			for (var c = 0; c < opts.numberOfMonths; c++) {
				html +=
					'<div class="pika-lendar">' +
					renderTitle(
						this,
						c,
						this.calendars[c].year,
						this.calendars[c].month,
						this.calendars[0].year,
						randId
					) +
					this.render(this.calendars[c].year, this.calendars[c].month, randId) +
					'</div>';
			}

			this.el.innerHTML = html;

			var autofocus = this.el.querySelector('td.is-selected > .pika-button');
			if (!autofocus) {
				autofocus = this.el.querySelector('td.is-startrange > .pika-button');
			}
			if (!autofocus) {
				autofocus = this.el.querySelector('td.is-today > .pika-button');
			}
			if (!autofocus) {
				autofocus = this.el.querySelector('td:not(.is-disabled) > .pika-button');
			}
			if (!autofocus) {
				autofocus = this.el.querySelector('.pika-button');
			}
			autofocus.setAttribute('tabindex', '0');

			this.emitEvent('draw');
		},

		focusPicker: function(forceFocus) {
			var self = this;
			var opts = this._options;

			if (!this.focusInside && !forceFocus) {
				return;
			}

			try {
				self.el.querySelector('.pika-button[tabindex="0"]').focus();
			} catch (e) {}

			if (opts.bound) {
				if (opts.field.type !== 'hidden') {
					sto(function() {
						self.el.querySelector('.pika-button[tabindex="0"]').focus();
					}, 1);
				}
			}

			this.focusInside = false;
		},

		adjustPosition: function() {
			this._request('adjustPosition');
		},

		_adjustPosition: function() {
			var field,
				pEl,
				width,
				height,
				viewportWidth,
				viewportHeight,
				scrollTop,
				left,
				top,
				clientRect;

			if (this._options.container) return;

			this.el.style.position = 'absolute';

			field = this._options.positionTarget || this._options.trigger;
			pEl = field;
			width = this.el.offsetWidth;
			height = this.el.offsetHeight;
			viewportWidth = window.innerWidth || document.documentElement.clientWidth;
			viewportHeight = window.innerHeight || document.documentElement.clientHeight;
			scrollTop =
				window.pageYOffset || document.body.scrollTop || document.documentElement.scrollTop;

			if (typeof field.getBoundingClientRect === 'function') {
				clientRect = field.getBoundingClientRect();
				left = clientRect.left + window.pageXOffset;
				if (clientRect.bottom + height < viewportHeight) {
					top = clientRect.bottom + window.pageYOffset; // at bottom
				} else {
					top = clientRect.top - height + window.pageYOffset; // at top
				}
			} else {
				left = pEl.offsetLeft;
				top = pEl.offsetTop + pEl.offsetHeight;
				while ((pEl = pEl.offsetParent)) {
					left += pEl.offsetLeft;
					top += pEl.offsetTop;
				}
				if (top + height > scrollTop + viewportHeight) {
					top = top - pEl.offsetHeight - height; // to top
				}
			}

			var halign = 0;
			if (this._options.position.indexOf('right') > -1) {
				halign = 1;
			} else if (this._options.position.indexOf('center') > -1) {
				halign = 0.5;
			}

			left -= (width - field.offsetWidth) * halign;

			// default position is bottom & left
			if (this._options.reposition) {
				var overflow = {
					right: Math.max(0, left + width - (viewportWidth - 20)),
					left: Math.max(0, 20 - left),
					top: Math.max(0, -top)
				};
				left += overflow.left - overflow.right;
				top += overflow.top;
			}

			this.el.style.left = left + 'px';
			this.el.style.top = top + 'px';
		},

		getDayConfig: function(day) {
			var opts = this._options,
				isSelected = isDate(this._date) ? areDatesEqual(day, this._date) : false,
				isToday = areDatesEqual(day, now),
				dayNumber = day.getDate(),
				monthNumber = day.getMonth(),
				yearNumber = day.getFullYear(),
				isStartRange = opts.startRange && areDatesEqual(opts.startRange, day),
				isEndRange = opts.endRange && areDatesEqual(opts.endRange, day),
				isInRange =
					opts.startRange &&
					opts.endRange &&
					opts.startRange < day &&
					day < opts.endRange,
				isDisabled =
					(opts.minDate && day < opts.minDate) ||
					(opts.maxDate && day > opts.maxDate) ||
					(opts.disableWeekends && isWeekend(day)) ||
					(opts.disableDayFn && opts.disableDayFn.call(this, day));

			var dayConfig = {
				date: day,
				day: dayNumber,
				month: monthNumber,
				year: yearNumber,
				isSelected: isSelected,
				isToday: isToday,
				isDisabled: isDisabled,
				isStartRange: isStartRange,
				isEndRange: isEndRange,
				isInRange: isInRange,
				showDaysInNextAndPreviousMonths: opts.showDaysInNextAndPreviousMonths,
				td: {},
				button: {}
			};

			dayConfig.text = dayNumber;
			dayConfig.label = opts.labelFn.call(this, dayConfig);
			if (opts.dayFn) {
				dayConfig = opts.dayFn.call(this, dayConfig) || dayConfig;
			}

			return dayConfig;
		},

		/**
		 * render HTML for a particular month
		 */
		render: function(year, month, randId) {
			var opts = this._options,
				days = getDaysInMonth(year, month),
				before = new Date(year, month, 1).getDay(),
				data = [],
				row = [];

			now = new Date();
			setToStartOfDay(now);
			if (opts.firstDay > 0) {
				before -= opts.firstDay;
				if (before < 0) {
					before += 7;
				}
			}
			var previousMonth = month === 0 ? 11 : month - 1,
				nextMonth = month === 11 ? 0 : month + 1,
				yearOfPreviousMonth = month === 0 ? year - 1 : year,
				yearOfNextMonth = month === 11 ? year + 1 : year,
				daysInPreviousMonth = getDaysInMonth(yearOfPreviousMonth, previousMonth);
			var cells = days + before,
				after = cells;

			var selectedInMonth = -1;

			while (after > 7) {
				after -= 7;
			}
			cells += 7 - after;
			if (
				this._date &&
				new Date(year, month, 1) <= this._date &&
				new Date(year, month + 1, 1) > this._date
			) {
				selectedInMonth = this._date;
			} else if (new Date(year, month, 1) <= now && new Date(year, month + 1, 1) > now) {
				selectedInMonth = now;
			} else {
				selectedInMonth = new Date(year, month, 1);
			}

			for (var i = 0, r = 0; i < cells; i++) {
				var day = new Date(year, month, 1 + (i - before)),
					dayConfig = this.getDayConfig(day);

				dayConfig.isEmpty = i < before || i >= days + before;
				dayConfig.tabindex = '-1';

				row.push(renderDay(dayConfig));

				if (++r === 7) {
					if (opts.showWeekNumber) {
						row.unshift(renderWeek(i - before, month, year));
					}
					data.push(renderRow(row, opts.isRTL));
					row = [];
					r = 0;
				}
			}
			return renderTable(opts, data, randId);
		},

		isValid: function() {
			if (!isDate(this._date)) {
				return 0;
			}
			if (isDate(this._options.minDate) && this._date < this._options.minDate) {
				return false;
			}
			if (isDate(this._options.maxDate) && this._date > this._options.maxDate) {
				return false;
			}
			return true;
		},

		isVisible: function() {
			return this._visible;
		},

		show: function() {
			var opts = this._options;
			clearTimeout(this.hideTimeout);

			if (this._date) {
				this.gotoDate(this._date);
			}

			document.body.appendChild(this.speakEl);
			if (opts.container) {
				opts.container.appendChild(this.el);
			} else if (opts.bound) {
				document.body.appendChild(this.el);
			} else if (opts.field) {
				opts.field.parentNode.insertBefore(this.el, opts.field.nextSibling);
			}

			if (!this.isVisible()) {
				removeClass(this.el, 'is-hidden');
				this._visible = true;
				this.draw();
				if (this._options.bound) {
					this.timeShowed = new Date();
					addEvent(document, 'click', this._onDocumentClick);
					this.adjustPosition();
				}
				if (this._options.field) {
					addClass(this._options.field, 'is-visible-pikaday');
					this.recentValue = this._options.field.value;
				}
				this.emitEvent('open');
				if (this._options.field && this._options.field != this._options.trigger) {
					this.speak(this.getLabel());
				}
			}
		},

		cancel: function() {
			var field = this._options.field;
			if (field) {
				field.value = this.recentValue;
			}
			try {
				field.select();
			} catch (e) {}
			log('Hiding because cancelled');
			this.hide(true);
		},

		hideAfter: function(delay, cancelled) {
			var self = this;
			clearTimeout(this.hideTimeout);
			if (this._visible !== false) {
				log('Will hide after ' + delay + 'ms.');
				this.hideTimeout = sto(function() {
					self.hide(cancelled);
				}, delay);
			}
		},

		hide: function(cancelled) {
			var v = this._visible;
			if (v !== false) {
				clearTimeout(this.hideTimeout);
				if (this.requested) {
					cancelAnimationFrame(this.requested.request);
					this.requested = null;
				}
				this.hasKey = false;
				if (this._options.bound) {
					removeEvent(document, 'click', this._onDocumentClick);
				}
				if (this._options.field) {
					removeClass(this._options.field, 'is-visible-pikaday');
				}
				if (this._options.bound) {
					if (this.el.parentNode) {
						this.el.parentNode.removeChild(this.el);
					}
				}
				this._visible = false;
				this.emitEvent('close');
				if (this.speakEl.parentNode) {
					document.body.removeChild(this.speakEl);
				}
			}
		},

		/**
		 * GAME OVER
		 */
		destroy: function() {
			this.hide();

			removeEvent(this.el, 'mousedown', this._onClick, true);
			removeEvent(this.el, 'touchend', this._onClick, true);
			removeEvent(this.el, 'change', this._onChange);
			removeEvent(this.el, 'keydown', this._onKeyChange);
			if (this._options.field) {
				removeEvent(this._options.field, 'change', this._onInputChange);
				if (this._options.bound) {
					removeEvent(this._options.trigger, 'click', this._onInputClick);
					removeEvent(document, 'touchstart', this._onTouch, { passive: true });
					removeEvent(this._options.trigger, 'focus', this._onInputFocus);
					removeEvent(this._options.trigger, 'blur', this._onInputBlur);
					removeEvent(this._options.trigger, 'keydown', this._onKeyChange);
				}
			}

			this.emitEvent('destroy');
			this.off();
		}
	};

	for (var name in EvEmitter.prototype) {
		Pikaday.prototype[name] = EvEmitter.prototype[name];
	}

	return Pikaday;
});
