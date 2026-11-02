define(["require", "exports"], function (require, exports) {
	Object.defineProperty(exports, "__esModule", { value: true });

	exports.autocompletes = {
		Function: {
            "add_send_hook()": {
                "insertText": "add_send_hook($0)",
                "documentation": {
                value: "```lua\nfunction raknet.add_send_hook(callback: (packet: RakNetPacket) -\u003e nil): ()\n```\n\nRegisters a callback that runs before a `RakNetPacket` is sent.\n\nParameters:\n- callback: function - The callback function to register.\n\n### Example\n\n```lua\nraknet.add_send_hook(function(packet)\r\n    print(\"ID:\", packet.PacketId)\r\n    print(\"Size:\", packet.Size)\r\n    print(\"Priority:\", packet.Priority)\r\n    print(\"Data (as buffer):\", packet.AsBuffer)\r\n    print(\"Data (as array):\", packet.AsArray)\r\n    print(\"Data (as string):\", packet.AsString)\r\n    print(\"Reliability:\", packet.Reliability)\r\n    print(\"Ordering Channel:\", packet.OrderingChannel)\r\nend)\n```",
                },
            },

            "remove_send_hook()": {
                "insertText": "remove_send_hook(${1:callback})",
                "documentation": {
                value: "```lua\nfunction raknet.remove_send_hook(callback: function): ()\n```\n\nRemoves a previously registered send hook.\n\nParameters:\n- callback: function - The callback function to remove.\n\n### Example\n\n```lua\nlocal send_hook = nil\r\nsend_hook = function(packet)\r\n    print(\"ID:\", packet.PacketId)\r\n    print(\"Size:\", packet.Size)\r\n    print(\"Priority:\", packet.Priority)\r\n    print(\"Data (as buffer):\", packet.AsBuffer)\r\n    print(\"Data (as array):\", packet.AsArray)\r\n    print(\"Data (as string):\", packet.AsString)\r\n    print(\"Reliability:\", packet.Reliability)\r\n    print(\"Ordering Channel:\", packet.OrderingChannel)\r\n\r\n    raknet.remove_send_hook(send_hook)\r\nend\r\n\r\nraknet.add_send_hook(send_hook)\n```",
                },
            },

            "send()": {
                "insertText": "send(${1:packet}, ${2:priority}, ${3:reliability}, ${4:orderingChannel})",
                "documentation": {
                value: "```lua\nfunction raknet.send(packet: buffer | table | string, priority: int, reliability: int, orderingChannel: int): ()\n```\n\nSends a packet with a payload, priority, reliability, and ordering channel.\n\nParameters:\n- packet: buffer | table | string - The packet to send.\n- priority: int - The priority of the packet.\n- reliability: int - The reliability mode of the packet.\n- orderingChannel: int - The ordering channel of the packet used for ordered traffic.\n\n### Example\n\n```lua\nlocal buf = buffer.create(2);\r\nbuffer.writeu8(buf, 1, 123);\r\n\r\nraknet.send(buf, 1, 0, 0)\n```",
                },
            },
		},
	};
});