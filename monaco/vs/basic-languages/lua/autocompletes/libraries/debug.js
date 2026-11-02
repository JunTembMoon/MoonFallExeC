define(["require", "exports"], function (require, exports) {
	Object.defineProperty(exports, "__esModule", { value: true });

	exports.autocompletes = {
		Function: {

			/**
			 * Roblox
			 */

			'traceback()': {
				insertText: 'traceback(${1:thread}, ${2:message}, ${3:level})',
				documentation: {
					value: [
						'```lua', 'function traceback([thread,] [message: any [, level: any(1)]])\n  -> message: any', '```',
						'',
						'Returns a string with a traceback of the call stack. The optional message string is appended at the beginning of the traceback.',
						'',
						'[View documents](https://developer.roblox.com/en-us/api-reference/lua-docs/debug)',
					].join('\n')
				},
			},

			'profilebegin()': {
				insertText: 'profilebegin(${1:label})',
				documentation: {
					value: [
						'```lua', 'function profilebegin(label: string)', '```',
						'',
						'Opens a microprofiler label.',
						'',
						'[View documents](https://developer.roblox.com/en-us/api-reference/lua-docs/debug)',
					].join('\n')
				},
			},

			'profileend()': {
				insertText: 'profileend()',
				documentation: {
					value: [
						'```lua', 'function profileend()', '```',
						'',
						'Closes the top microprofiler label.',
						'',
						'[View documents](https://developer.roblox.com/en-us/api-reference/lua-docs/debug)',
					].join('\n')
				},
			},

			'info()': {
				insertText: 'info(${1:level}, ${2:options})',
				documentation: {
					value: [
						'```lua', 'function info(level: number, options: string)\n  -> table', '```',
						'',
						'Returns debug information about a given stack frame or function object based on the options string (that can contain characters nslfa).',
						'',
						'[View documents](https://developer.roblox.com/en-us/api-reference/lua-docs/debug)',
					].join('\n')
				},
			},

			"getcallstack()": {
				"insertText": "getcallstack(${1:offset})",
				"documentation": {
				value: "```lua\nfunction debug.getcallstack(offset: number): table\n```\n\nReturns a table of the entire stack\u0027s information. Table array fields: source (definition), line (start line), what (\\\"Lua\\\", \\\"C\\\"), name, func.\n\nAlias: ``getcallstack``\n\nParameters:\n- offset: number - The offset you want the callstack table to begin at.\n\n### Example\n\n```lua\nlocal function foo()\r\n    local callStack = debug.getcallstack()\r\n\r\n    print(\"Number of calls:\", #callStack) --\u003e 3\r\n    print(\"Name of caller:\", callStack[2].name) --\u003e bar\r\nend\r\n\r\nlocal function bar()\r\n    foo()\r\nend\r\n\r\nbar()\n```",
				},
			},

			"getconstant()": {
				"insertText": "getconstant(${1:function}, ${2:index})",
				"documentation": {
				value: "```lua\nfunction debug.getconstant(function: function | number, index: number): any\n```\n\nReturns a singular constant that\u0027s derived from a function. Selected via index.\n\nAlias: ``getconstant``\n\nParameters:\n- function: function | number - The function whose constant is returned.\n- index: number - The index of the constant to return.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 123\r\nend\r\n\r\nlocal constant = debug.getconstant(foo, 1)\r\nprint(constant) --\u003e 123\n```",
				},
			},

			"getconstants()": {
				"insertText": "getconstants(${1:function})",
				"documentation": {
				value: "```lua\nfunction debug.getconstants(function: function | number): { any? }\n```\n\nReturns a table of constants that\u0027s derived from a function.\n\nAlias: ``getconstants``\n\nParameters:\n- function: function | number - The function whose constants are returned.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 123\r\nend\r\n\r\nlocal constantTable = debug.getconstants(foo)\r\nfor index, constant in constantTable do\r\n    print(index, constant)\r\nend\n```",
				},
			},

			"getinfo()": {
				"insertText": "getinfo(${1:function}, ${2:what})",
				"documentation": {
				value: "```lua\nfunction debug.getinfo(function: function | number, what: string): table\n```\n\nReturns a table of information that\u0027s derived from a function or stack level.\\nTable fields: source (definition), short_src (truncated), linedefined (start line),\\nwhat (\\\"Lua\\\", \\\"C\\\", \\\"main\\\"), name, namewhat (scope), nups (upvalue count),\\nand func (function itself).\\n\n\nAlias: ``getinfo``\n\nParameters:\n- function: function | number - The function or stack level whose information is collected and returned.\n- what: string - Used to specify what information is returned in the table. Options include: \"n\" for name and namewhat, \"s\" for source and line details, \"l\" for currentline, and \"f\" for the function itself.\n\n### Example\n\n```lua\nfunction foo()\r\n    return \"Hello, world!\"\r\nend\r\n\r\nlocal functionInfo = debug.getinfo(foo)\r\nfor i, v in functionInfo do\r\n    print(i, v)\r\nend\n```",
				},
			},

			"getproto()": {
				"insertText": "getproto(${1:function}, ${2:index}, ${3:active})",
				"documentation": {
				value: "```lua\nfunction debug.getproto(function: function | number, index: number, active: boolean?): function | {function}\n```\n\nGets a cloned proto inside the \u0027func\u0027 unless the \u0027active\u0027 is specified which returns a table of all active protos.\n\nAlias: ``getproto``\n\nParameters:\n- function: function | number - The function or level you want to get the proto from.\n- index: number - The indice for the proto.\n- active: number - Return actively used protos instead of cloned ones.\n\n### Example\n\n```lua\nlocal function foo()\r\n\tlocal function bar()\r\n\t\tprint(\"foo\u0027s inner proto bar!\")\r\n\tend\r\nend\r\n\r\nlocal bar = debug.getproto(foo, 1, true)[1]\r\nbar() --\u003e foo\u0027s inner proto bar!\n```",
				},
			},

			"getprotos()": {
				"insertText": "getprotos(${1:function})",
				"documentation": {
				value: "```lua\nfunction debug.getprotos(function: function | number): {function}\n```\n\nReturn a list of all cloned protos.\n\nAlias: ``getprotos``\n\nParameters:\n- function: function | number - The function or level you want to get the protos from.\n\n### Example\n\n```lua\nlocal function foo()\r\n\tlocal function bar()\r\n\t\tprint(\"foo\u0027s inner proto bar!\")\r\n\tend\r\nend\r\n\r\nprint(debug.info(debug.getprotos(foo)[1], \"n\")) --\u003e bar\n```",
				},
			},

			"getregistry()": {
				"insertText": "getregistry()",
				"documentation": {
				value: "```lua\nfunction debug.getregistry(): { [any]: any }\n```\n\nReturns the global registry table. The registry is used to store references. Any object referenced in the registry will never be collected by the garbage collector, as the registry itself will never be collected. Thus a strong reference will always be held.\n\nAlias: ``getregistry``\n\n### Example\n\n```lua\nlocal registry = debug.getregistry()\r\nfor i, v in registry do\r\n    print(i, v)\r\nend\n```",
				},
			},

			"getsafeenv()": {
				"insertText": "getsafeenv(${1:object})",
				"documentation": {
				value: "```lua\nfunction debug.getsafeenv(object: function | table | thread)\n```\n\nReturns the safeenv flag.\n\nAlias: ``debug.isuntouched``\n\nParameters:\n- object: function | table | thread - The object you would like to get the safeenv of.\n\n### Example\n\n```lua\nprint(debug.getsafeenv()) --\u003e false\r\ndebug.setsafeenv(true)\r\nprint(debug.getsafeenv()) --\u003e true\r\n\r\n-- Since we are breaking safeenv protections by\r\n-- replacing a global function with getfenv, safeenv\r\n-- becomes false. Also applicable to setfenv.\r\ngetfenv().warn = function() end\r\nprint(debug.getsafeenv()) --\u003e false\n```",
				},
			},

			"getstack()": {
				"insertText": "getstack(${1:level}, ${2:index})",
				"documentation": {
				value: "```lua\nfunction debug.getstack(level: number, index: number?): ( any | { any } )\n```\n\nReturns a table (of the stack) or a singular object from the stack. Only returns objects that are currently on the stack.\n\nAlias: ``getstack``\n\nParameters:\n- level: number - The stack level at which the objects are collected.\n- index: number - The index of a specific object on the stack to return. If omitted, the entire stack at the given level is returned as a table.\n\n### Example\n\n```lua\n-- Imagine this is a hook of some kind.\r\nfunction foo(vec3)\r\n    local stack = debug.getstack(2)\r\n    for i, v in stack do\r\n        print(i, v)\r\n    end\r\nend\r\n\r\nlocal function bar()\r\n    local vec3 = Vector3.new()\r\n\r\n    foo(vec3)\r\n\r\n    return vec3\r\nend\r\n\r\nbar()\n```",
				},
			},

			"getupvalue()": {
				"insertText": "getupvalue(${1:function}, ${2:index})",
				"documentation": {
				value: "```lua\nfunction debug.getupvalue(function: function | number, index: number): any\n```\n\nReturns a singular upvalue that\u0027s derived from a function\u0027s upvalue list. Selected via index.\n\nAlias: ``getupvalue``\n\nParameters:\n- function: function | number - The function whose upvalue is returned.\n- index: number - The index of the upvalue to return.\n\n### Example\n\n```lua\nlocal bar = \"Hello, World!\"\r\nfunction foo()\r\n    print(bar)\r\nend\r\n\r\nlocal upvalue = debug.getupvalue(foo, 1)\r\nprint(upvalue)\n```",
				},
			},

			"getupvalues()": {
				"insertText": "getupvalues(${1:function})",
				"documentation": {
				value: "```lua\nfunction debug.getupvalues(function: function | number): { any }\n```\n\nReturns a table of upvalues from a function\u0027s upvalue\u0027s list.\n\nAlias: ``getupvalues``\n\nParameters:\n- function: function | number - The function whose upvalues are returned. Stack levels are also supported.\n\n### Example\n\n```lua\nlocal upvalue = \"Hello, World!\"\r\nfunction foo()\r\n    print(upvalue)\r\nend\r\n\r\nlocal upvalues = debug.getupvalues(foo)\r\nfor i, v in upvalues do\r\n    print(i, v)\r\nend\n```",
				},
			},

			"isvalidlevel()": {
				"insertText": "isvalidlevel(${1:level})",
				"documentation": {
				value: "```lua\nfunction debug.isvalidlevel(level: number)\n```\n\nChecks if \u0027level\u0027 is valid in the stack\n\nAlias: ``debug.validlevel``\n\nParameters:\n- level: number - The level you want to check.\n\n### Example\n\n```lua\nlocal function a()\r\n  print(debug.isvalidlevel(3))\r\nend\r\n\r\na() --\u003e false\r\nnewlclosure(a)() --\u003e true\n```",
				},
			},

			"setconstant()": {
				"insertText": "setconstant(${1:function}, ${2:index}, ${3:replacement})",
				"documentation": {
				value: "```lua\nfunction debug.setconstant(function: function | number, index: number, replacement: any): ()\n```\n\nSets a singular constant that\u0027s derived from a function. Selected via index.\n\nAlias: ``setconstant``\n\nParameters:\n- function: function | number - The function whose constant is set.\n- index: number - The index of the constant to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 696969420\r\nend\r\n\r\ndebug.setconstant(foo, 1, 0)\r\n\r\nprint(foo())\n```",
				},
			},

			"setinfo()": {
				"insertText": "setinfo(${1:func}, ${2:info})",
				"documentation": {
				value: "```lua\nfunction debug.setinfo(func: function, info: table): ()\n```\n\nSets the debug info around the \u0027func\u0027.\n\nAlias: ``setinfo``\n\nParameters:\n- func: function - The function you would like to change the info of\n- info: table - The info you would like to change. (name, source, short\\_src, currentline)\n\n### Example\n\n```lua\nlocal foo = function()\r\n  print(debug.traceback())\r\nend\r\n\r\nfoo() --\u003e Original info\r\n\r\ndebug.setinfo(foo, {\r\n  name = \"bar\",\r\n  source = \"bar\",\r\n  short_src = \"bar\",\r\n  currentline = 123\r\n})\r\n\r\nfoo() --\u003e Spoofed one\n```",
				},
			},

			"setname()": {
				"insertText": "setname(${1:function}, ${2:name})",
				"documentation": {
				value: "```lua\nfunction debug.setname(function: function | number, name: string): ()\n```\n\nChanges the function name specified to the set one.\n\nAlias: ``setname``\n\nParameters:\n- function: function | number - The function to set the name of.\n- name: number - The name you want to set the function to.\n\n### Example\n\n```lua\nlocal function foo()\r\n  print(\"name\", debug.info(1, \"n\"))\r\nend\r\n\r\nfoo() -- name foo\r\ndebug.setname(foo, \"bar\")\r\nfoo() -- name bar\n```",
				},
			},

			"setsafeenv()": {
				"insertText": "setsafeenv(${1:func}, ${2:safe})",
				"documentation": {
				value: "```lua\nfunction debug.setsafeenv(func: function | table | thread | boolean, safe: boolean?)\n```\n\nMarks the safeenv for an object.\n\nAlias: ``debug.setuntouched``\n\nParameters:\n- object: function | table | thread | boolean - The object you would like to set the safeenv of. (If a boolean is provided it will set the current state\u0027s safeenv)\n- safe: boolean - What to set the safeenv of the \u0027func\u0027.\n\n### Example\n\n```lua\nprint(debug.getsafeenv()) --\u003e false\r\ndebug.setsafeenv(true)\r\nprint(debug.getsafeenv()) --\u003e true\r\n\r\n-- Since we are breaking safeenv protections by\r\n-- replacing a global function with getfenv, safeenv\r\n-- becomes false. Also applicable to setfenv.\r\ngetfenv().warn = function() end\r\nprint(debug.getsafeenv()) --\u003e false\n```",
				},
			},

			"setstack()": {
				"insertText": "setstack(${1:level}, ${2:index}, ${3:replacement})",
				"documentation": {
				value: "```lua\nfunction debug.setstack(level: number, index: number, replacement: any): ()\n```\n\nSets a singular object from the stack.\n\nAlias: ``setstack``\n\nParameters:\n- level: number - The stack level of the function whose stack object is set.\n- index: number - The index of the stack object to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\n-- Imagine this is a hook of some kind.\r\nfunction foo(vec3)\r\n    local replacement = Vector3.new(100, 100, 100)\r\n    debug.setstack(2, 1, replacement)\r\nend\r\n\r\nlocal function bar()\r\n    local vec3 = Vector3.new()\r\n\r\n    foo(vec3)\r\n\r\n    return vec3\r\nend\r\n\r\nprint(bar())\n```",
				},
			},

			"setupvalue()": {
				"insertText": "setupvalue(${1:function}, ${2:index}, ${3:replacement})",
				"documentation": {
				value: "```lua\nfunction debug.setupvalue(function: function | number, index: number, replacement: any): ()\n```\n\nSets a singular upvalue that\u0027s derived from a function\u0027s upvalue list. Selected via index.\n\nAlias: ``setupvalue``\n\nParameters:\n- function: function | number - The function whose upvalue is set.\n- index: number - The index of the upvalue to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\nlocal upvalue = 0\r\n\r\nlocal function foo()\r\n    return upvalue\r\nend\r\n\r\nlocal function bar()\r\n    upvalue += 1\r\nend\r\n\r\nprint(foo())\r\n\r\ndebug.setupvalue(foo, 1, 10000)\r\n\r\nprint(foo())\n```",
				},
			},
		},
	};
});