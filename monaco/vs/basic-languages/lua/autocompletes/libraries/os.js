define(["require", "exports"], function (require, exports) {
	Object.defineProperty(exports, "__esModule", { value: true });

	exports.autocompletes = {

		Function: {

			/**
			 * Roblox
			 */

            /**
             * original documentation:
             * 
             *   "@luau/global/os.clock": {
    "documentation": "Returns elapsed time in seconds since an arbitrary baseline with sub-microsecond precision.",
    "params": [],
    "returns": [
      "@luau/global/os.clock/return/0"
    ],
    "learn_more_link": "https://luau.org/library/#os-library",
    "code_sample": ""
  },
  "@luau/global/os.date/param/0": {
    "documentation": "Must be either <code>\"*t\"</code> or <code>\"!*t\"</code>."
  },
  "@luau/global/os.date/param/1": {
    "documentation": "The time value to format."
  },
  "@luau/global/os.date/return/0": {
    "documentation": ""
  },
  "@luau/global/os.date": {
    "documentation": "Formats the given string with date/time information based on the given time.",
    "params": [
      {
        "name": "formatString",
        "documentation": "@luau/global/os.date/param/0"
      },
      {
        "name": "time",
        "documentation": "@luau/global/os.date/param/1"
      }
    ],
    "returns": [
      "@luau/global/os.date/return/0"
    ],
    "learn_more_link": "https://luau.org/library/#os-library",
    "code_sample": ""
  },
  "@luau/global/os.difftime/param/0": {
    "documentation": ""
  },
  "@luau/global/os.difftime/param/1": {
    "documentation": ""
  },
  "@luau/global/os.difftime/return/0": {
    "documentation": ""
  },
  "@luau/global/os.difftime": {
    "documentation": "Returns the number of seconds from one time to another.",
    "params": [
      {
        "name": "t2",
        "documentation": "@luau/global/os.difftime/param/0"
      },
      {
        "name": "t1",
        "documentation": "@luau/global/os.difftime/param/1"
      }
    ],
    "returns": [
      "@luau/global/os.difftime/return/0"
    ],
    "learn_more_link": "https://luau.org/library/#os-library",
    "code_sample": ""
  },
  "@luau/global/os.time/param/0": {
    "documentation": "A dictionary table describing a specific time, similar to that returned by <code>os.date()</code>. If not provided, uses the current UTC time."
  },
  "@luau/global/os.time/return/0": {
    "documentation": ""
  },
  "@luau/global/os.time": {
    "documentation": "Returns how many seconds have passed since the Unix epoch (1 January 1970, 00:00:00) under current UTC time.",
    "params": [
      {
        "name": "time",
        "documentation": "@luau/global/os.time/param/0"
      }
    ],
    "returns": [
      "@luau/global/os.time/return/0"
    ],
    "learn_more_link": "https://luau.org/library/#os-library",
    "code_sample": ""
  },
             */

            "clock": {
                "insertText": "clock()",
                "documentation": {
                    "value": "```lua\nfunction clock()\n```\n\nReturns elapsed time in seconds since an arbitrary baseline with sub-microsecond precision.",
                }
            },

            "date": {
                "insertText": "date(${1:formatString}, ${2:time})",
                "documentation": {
                    "value": "```lua\nfunction date(formatString, time)\n```\n\nFormats the given string with date/time information based on the given time.",
                }
            },

            "difftime": {
                "insertText": "difftime(${1:t2}, ${2:t1})",
                "documentation": {
                    "value": "```lua\nfunction difftime(t2, t1)\n```\n\nReturns the number of seconds from one time to another.",
                }
            },

            "time": {
                "insertText": "time(${1:time})",
                "documentation": {
                    "value": "```lua\nfunction time(time)\n```\n\nReturns how many seconds have passed since the Unix epoch (1 January 1970, 00:00:00) under current UTC time.",
                }
            }
		},
	};
});