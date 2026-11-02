define(["require", "exports"], function (require, exports) {
	Object.defineProperty(exports, "__esModule", { value: true });

	exports.autocompletes = {
		Function: {
            "Escape()": {
                "insertText": "Escape(${1:contents})",
                "documentation": {
                value: "```lua\nfunction Regex.Escape(contents: string): string\n```\n\nEscapes a string for use in a regular expression.\n\nParameters:\n- contents: string - The string to escape.\n\n### Example\n\n```lua\nlocal input = \"[DEBUG] (ID): 99821\"\r\nlocal label = \"[DEBUG] (ID): \"\r\n\r\nlocal escaped = Regex.Escape(label)\r\nlocal regex = Regex.new(escaped .. \"(\\\\d+)\")\r\nlocal match = regex:Match(input)\r\n\r\nif match then\r\n    print(\"ID:\", regex:Replace(match, \"$1\"))\r\nend\n```",
                },
            },

            "new()": {
                "insertText": "new(${1:pattern})",
                "documentation": {
                value: "```lua\nfunction Regex.new(pattern: string): Regex\n```\n\nConstructs a new `Regex` object using the specified pattern.\n\nParameters:\n- pattern: string - The regular expression pattern.\n\n### Example\n\n```lua\nlocal input = \"My Cool Id: 31235335\"\r\nlocal regex = Regex.new(\"My Cool Id:\\\\s*(\\\\w+)\")\r\nlocal match = regex:Match(input)\r\n\r\nif match then\r\n    print(\"ID:\", regex:Replace(match, \"$1\"))\r\nend\n```",
                },
            },
		},
	};
});