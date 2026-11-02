define(["require", "exports"], function (require, exports) {
	Object.defineProperty(exports, "__esModule", { value: true });

	exports.autocompletes = {
		Function: {
            "get_original_thread()": {
                "insertText": "get_original_thread()",
                "documentation": {
                value: "```lua\nfunction oth.get_original_thread(): thread\n```\n\nReturn the original thread this hook comes from, or nil if the current thread is not a hook.\n\n### Example\n\n```lua\noth.hook(game.GetService, function(...)\r\n    local thread = oth.get_original_thread()\r\n    local script = getscriptfromthread(thread)\r\n\r\n    if script and script.Parent == nil then\r\n        return task.wait(9e9)\r\n    end\r\n\r\n    return oth.get_root_callback()(...)\r\nend)\n```",
                },
            },

            "get_root_callback()": {
                "insertText": "get_root_callback()",
                "documentation": {
                value: "```lua\nfunction oth.get_root_callback(): function\n```\n\nRetrieves a function that can be used to call the original function in the context of a hook thread.\n\n### Example\n\n```lua\noth.hook(game.FindService, function(self, service)\r\n    if service == \"VirtualInputManager\" then\r\n        return nil\r\n    end\r\n\r\n    return oth.get_root_callback()(self, service)\r\nend)\n```",
                },
            },

            "hook()": {
                "insertText": "hook(${1:target}, ${2:hook})",
                "documentation": {
                value: "```lua\nfunction oth.hook(target: function, hook: function): ()\n```\n\nHooks a function by utilizing a secure \u0027Off-Thread\u0027 execution model that runs hook code on isolated threads. This method is specifically designed for hooking C functions where standard `hookfunction` might be detected.\n\nParameters:\n- target: function - The function to hook.\n- hook: function - The hook function.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(Instance.new, function(...)\r\n    print(\"Creating new instance:\", ...)\r\n\r\n    return old(...)\r\nend)\n```",
                },
            },

            "is_hook_thread()": {
                "insertText": "is_hook_thread()",
                "documentation": {
                value: "```lua\nfunction oth.is_hook_thread(): boolean\n```\n\nReturns whether or not this thread is a hook thread.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(math.random, function(...)\r\n    if oth.is_hook_thread() then\r\n        return 1\r\n    end\r\n    \r\n    return old(...)\r\nend)\n```",
                },
            },

            "unhook()": {
                "insertText": "unhook(${1:target})",
                "documentation": {
                value: "```lua\nfunction oth.unhook(target: function): ()\n```\n\nUnhooks a function previously hooked with `oth.hook`.\n\nParameters:\n- target: function - The function to unhook.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(print, function(...)\r\n    return warn(...)\r\nend)\r\n\r\nprint(\"This will be a warning.\")\r\n\r\noth.unhook(print)\r\n\r\nprint(\"This will be a print.\")\n```",
                },
            },
		},
	};
});