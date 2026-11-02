define(["require", "exports"], function (require, exports) {
  Object.defineProperty(exports, "__esModule", { value: true });

  exports.autocompletes = {
    "Function": {

      "appendfile()": {
        "insertText": "appendfile(${1:file}, ${2:contents})",
        "documentation": {
          value: "```lua\nfunction appendfile(file: string, contents: string): ()\n```\n\nAppend an already existing file\u0027s contents from workspace.\n\nParameters:\n- file: string - The path to the file you\u0027re looking to append.\n- contents: string - The contents you want to append the existing file.\n\n### Example\n\n```lua\nappendfile(\"test.txt\", \"\\n\" .. workspace:GetServerTimeNow())\n```",
        },
      },

      "cansignalreplicate()": {
        "insertText": "cansignalreplicate(${1:signal})",
        "documentation": {
          value: "```lua\nfunction cansignalreplicate(signal: RBXScriptSignal): boolean\n```\n\nReturns a boolean indicating whether an `RBXScriptSignal` can replicate (fire server events).\n\nParameters:\n- signal: RBXScriptSignal - The signal that is checked.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\")\r\nprint(cansignalreplicate(part.Touched))\n```",
        },
      },

      "cleardrawcache()": {
        "insertText": "cleardrawcache()",
        "documentation": {
          value: "```lua\nfunction cleardrawcache(): ()\n```\n\nRemoves all rendered drawing objects from the cache.\n\n### Example\n\n```lua\nfor i = 1, 10 do\r\n    local circle = Drawing.new(\"Circle\")\r\n    circle.Radius = 50\r\n    circle.Color = Color3.fromRGB(255, 0, 0)\r\n    circle.Filled = true\r\n    circle.NumSides = 32\r\n    circle.Position = Vector2.new(100 * i, 100)\r\n    circle.Transparency = 0.7\r\n    circle.Visible = true\r\nend\r\n\r\ntask.wait(1)\r\n\r\ncleardrawcache()\n```",
        },
      },

      "clearteleportqueue()": {
        "insertText": "clearteleportqueue()",
        "documentation": {
          value: "```lua\nfunction clearteleportqueue(): ()\n```\n\nClears the queue created by \u0027queueonteleport\u0027.\n\n### Example\n\n```lua\nqueueonteleport([[\r\n    print(\"Hello, world!\")\r\n]])\r\n\r\n-- No code will be executed after teleport\r\nclearteleportqueue()\n```",
        },
      },

      "create_comm_channel()": {
        "insertText": "create_comm_channel()",
        "documentation": {
          value: "```lua\nfunction create_comm_channel(): number, BindableEvent\n```\n\nReturns an identifier and a `BindableEvent`. Used in one-way communication between actors.\n\n### Example\n\n```lua\nlocal id, channel = create_comm_channel()\r\nchannel.Event:Connect(function(data)\r\n    print(data)\r\nend)\r\n\r\nrun_on_actor(getactors()[1], [[\r\n    local id = ...\r\n    local channel = get_comm_channel(id)\r\n    channel:Fire(\"Hello, World!\")\r\n]], id)\n```",
        },
      },

      "crypt.base64decode()": {
        "insertText": "crypt.base64decode(${1:data})",
        "documentation": {
          value: "```lua\nfunction crypt.base64decode(data: string): string\n```\n\nReturns a base64 decoded string.\n\nAlias: ``base64decode``\n\nParameters:\n- data: string - The data to be base64 decoded.\n\n### Example\n\n```lua\nlocal encodedData = \"SGVsbG8sIHdvcmxkIQ==\"\r\nprint(crypt.base64decode(encodedData))\n```",
        },
      },

      "crypt.base64encode()": {
        "insertText": "crypt.base64encode(${1:data})",
        "documentation": {
          value: "```lua\nfunction crypt.base64encode(data: string): string\n```\n\nReturns a base64 encoded string.\n\nAlias: ``base64encode``\n\nParameters:\n- data: string - The data to be base64 encoded.\n\n### Example\n\n```lua\nlocal data = \"Hello, world!\"\r\nlocal encoded = crypt.base64encode(data)\r\nprint(encoded)\n```",
        },
      },

      "crypt.decrypt()": {
        "insertText": "crypt.decrypt(${1:data}, ${2:key}, ${3:iv}, ${4:mode})",
        "documentation": {
          value: "```lua\nfunction crypt.decrypt(data: string, key: string, iv: string, mode: string): string\n```\n\nDecrypts provided data using AES encryption. Returns the decrypted data.\n\nParameters:\n- data: string - User provided data.\n- key: string - Base64 encoded decryption key.\n- iv: string - Base64 encoded initialization vector.\n- mode: string - Decryption mode. Decrytion mode options: OFB, GCM, ECB, CTR, CFB, and CBC. Default option is \"CBC\".\n\n### Example\n\n```lua\nlocal username = game:GetService(\"Players\").LocalPlayer.Character.Name\r\nprint(\"Username:\", username)\r\n\r\nlocal key = crypt.generatekey(16)\r\nlocal data, iv = crypt.encrypt(username, key)\r\n\r\nlocal decryptedData = crypt.decrypt(data, key, iv)\r\nprint(\"Decrypted result:\", decryptedData)\n```",
        },
      },

      "crypt.encrypt()": {
        "insertText": "crypt.encrypt(${1:data}, ${2:key}, ${3:iv}, ${4:mode})",
        "documentation": {
          value: "```lua\nfunction crypt.encrypt(data: string, key: string, iv: string?, mode: string?): (string, string)\n```\n\nEncrypts provided data using AES encryption. Returns both the encrypted data and the initialization vector (iv).\n\nParameters:\n- data: string - User provided data.\n- key: string - Base64 encoded encryption key.\n- iv: string - Base64 encoded initialization vector.\n- mode: string - Encryption mode. Encrytion mode options: OFB, GCM, ECB, CTR, CFB, and CBC. Default option is \"CBC\".\n\n### Example\n\n```lua\nlocal hwid = gethwid()\r\nprint(\"HWID:\", hwid)\r\n\r\nlocal key = crypt.generatekey(16)\r\nprint(\"Encryption key:\", key)\r\n\r\nlocal data, iv = crypt.encrypt(hwid, key)\r\nprint(data, iv)\n```",
        },
      },

      "crypt.generatebytes()": {
        "insertText": "crypt.generatebytes(${1:amount})",
        "documentation": {
          value: "```lua\nfunction crypt.generatebytes(amount: number): string\n```\n\nReturns a string of randomly generated bytes. The result is base64 encoded.\n\nParameters:\n- amount: number - The amount of random bytes to generate.\n\n### Example\n\n```lua\nlocal randomBytes = base64decode(crypt.generatebytes(16))\r\nprint(#randomBytes, randomBytes)\n```",
        },
      },

      "crypt.generatekey()": {
        "insertText": "crypt.generatekey(${1:keylength})",
        "documentation": {
          value: "```lua\nfunction crypt.generatekey(keylength: number?): string\n```\n\nGenerates and returns a random key. Frequently used in combination with with `crypt.encrypt` and `crypt.decrypt`.\n\nParameters:\n- keylength: number - Length of the random key to generate. Default is 32 bytes in length.\n\n### Example\n\n```lua\nlocal username = game:GetService(\"Players\").LocalPlayer.Character.Name\r\nprint(\"Username:\", username)\r\n\r\nlocal key = crypt.generatekey()\r\nprint(\"Encryption key:\", key)\r\n\r\nlocal data, iv = crypt.encrypt(username, key)\r\nprint(\"Encrypted username:\", data)\n```",
        },
      },

      "crypt.hash()": {
        "insertText": "crypt.hash(${1:data}, ${2:algorithm})",
        "documentation": {
          value: "```lua\nfunction crypt.hash(data: string, algorithm: string): string\n```\n\nHashes and returns user provided data using the specified hashing algorithm.\n\nParameters:\n- data: string - User provided data.\n- algorithm: string - The specified hashing algorithm. Algorithms include: \"md5\", \"sha256\", \"sha1\", \"sha384\", \"sha512\", \"sha3-224\", \"sha3-256\", \"sha3-384\", \"sha3-512\", \"sha224\".\n\n### Example\n\n```lua\nlocal data = game:GetService(\"Players\").LocalPlayer.Character.Name\r\nprint(\"Username:\", data)\r\n\r\nlocal hashAlgorithmList = {\r\n    \"md5\", \r\n    \"sha256\", \r\n    \"sha1\", \r\n    \"sha384\", \r\n    \"sha512\", \r\n    \"sha3-224\", \r\n    \"sha3-256\",\r\n    \"sha3-384\", \r\n    \"sha3-512\", \r\n    \"sha224\"\r\n}\r\n\r\nfor _, algorithm in hashAlgorithmList do\r\n    print(algorithm .. \":\", crypt.hash(data, algorithm))\r\nend\n```",
        },
      },

      "crypt.hmac()": {
        "insertText": "crypt.hmac(${1:key}, ${2:data}, ${3:algorithm})",
        "documentation": {
          value: "```lua\nfunction crypt.hmac(key: string, data: string, algorithm: string): string\n```\n\nGenerates and returns an HMAC (Hash-based Message Authentication Code). Frequently used in message authentication (see example below).\n\nParameters:\n- key: string - The secret key.\n- data: string - User provided data.\n- algorithm: string - The specified hashing algorithm. Algorithms include: \"md5\", \"sha1\", \"sha224\", \"sha256\", \"sha384\", \"sha512\", \"sha3-224\", \"sha3_224\", \"sha3-256\", \"sha3_256\", \"sha3-384\", \"sha3_384\", \"sha3-512\", and \"sha3_512\".\n\n### Example\n\n```lua\nlocal data = game:GetService(\"Players\").LocalPlayer.Character.Name\r\nprint(\"Username:\", data)\r\n\r\nlocal hashAlgorithmList = {\r\n    \"md5\",\r\n    \"sha1\",\r\n    \"sha224\",\r\n    \"sha256\",\r\n    \"sha384\",\r\n    \"sha512\",\r\n    \"sha3-224\",\r\n    \"sha3_224\",\r\n    \"sha3-256\",\r\n    \"sha3_256\",\r\n    \"sha3-384\",\r\n    \"sha3_384\",\r\n    \"sha3-512\",\r\n    \"sha3_512\"\r\n}\r\n\r\nfor _, algorithm in hashAlgorithmList do\r\n    print(algorithm .. \":\", crypt.hmac(crypt.generatebytes(16), data, algorithm))\r\nend\n```",
        },
      },

      "crypt.lz4compress()": {
        "insertText": "crypt.lz4compress(${1:data})",
        "documentation": {
          value: "```lua\nfunction crypt.lz4compress(data: string): string\n```\n\nReturns a compressed string using the LZ4 algorithm.\n\nAlias: ``lz4compress``\n\nParameters:\n- data: string - The user specified data.\n\n### Example\n\n```lua\nlocal data = \"Hello, world!\"\r\nlocal compressed = crypt.lz4compress(data)\r\nprint(compressed)\n```",
        },
      },

      "crypt.lz4decompress()": {
        "insertText": "crypt.lz4decompress(${1:data}, ${2:originallength})",
        "documentation": {
          value: "```lua\nfunction crypt.lz4decompress(data: string, originallength: number): string\n```\n\nReturns a decompressed string using the LZ4 algorithm.\n\nAlias: ``lz4decompress``\n\nParameters:\n- data: string - The user specified data.\n- originallength: number - The length of the original (non lz4 compressed) string.\n\n### Example\n\n```lua\nlocal data = \"Hello, world!\"\r\nlocal compressed = crypt.lz4compress(data)\r\n\r\nlocal decompressed = crypt.lz4decompress(compressed, #data)\r\nprint(decompressed)\n```",
        },
      },

      "crypt.random()": {
        "insertText": "crypt.random(${1:amount})",
        "documentation": {
          value: "```lua\nfunction crypt.random(amount: number): string\n```\n\nReturns a string of randomly generated bytes. The result is not base64 encoded.\n\nParameters:\n- amount: number - The amount of random bytes to generate.\n\n### Example\n\n```lua\nlocal randomBytes = base64decode(crypt.random(16))\r\nprint(#randomBytes, randomBytes)\n```",
        },
      },

      "debug.getcallstack()": {
        "insertText": "debug.getcallstack(${1:offset})",
        "documentation": {
          value: "```lua\nfunction debug.getcallstack(offset: number): table\n```\n\nReturns a table of the entire stack\u0027s information. Table array fields: source (definition), line (start line), what (\\\"Lua\\\", \\\"C\\\"), name, func.\n\nAlias: ``getcallstack``\n\nParameters:\n- offset: number - The offset you want the callstack table to begin at.\n\n### Example\n\n```lua\nlocal function foo()\r\n    local callStack = debug.getcallstack()\r\n\r\n    print(\"Number of calls:\", #callStack) --\u003e 3\r\n    print(\"Name of caller:\", callStack[2].name) --\u003e bar\r\nend\r\n\r\nlocal function bar()\r\n    foo()\r\nend\r\n\r\nbar()\n```",
        },
      },

      "debug.getconstant()": {
        "insertText": "debug.getconstant(${1:function}, ${2:index})",
        "documentation": {
          value: "```lua\nfunction debug.getconstant(function: function | number, index: number): any\n```\n\nReturns a singular constant that\u0027s derived from a function. Selected via index.\n\nAlias: ``getconstant``\n\nParameters:\n- function: function | number - The function whose constant is returned.\n- index: number - The index of the constant to return.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 123\r\nend\r\n\r\nlocal constant = debug.getconstant(foo, 1)\r\nprint(constant) --\u003e 123\n```",
        },
      },

      "debug.getconstants()": {
        "insertText": "debug.getconstants(${1:function})",
        "documentation": {
          value: "```lua\nfunction debug.getconstants(function: function | number): { any? }\n```\n\nReturns a table of constants that\u0027s derived from a function.\n\nAlias: ``getconstants``\n\nParameters:\n- function: function | number - The function whose constants are returned.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 123\r\nend\r\n\r\nlocal constantTable = debug.getconstants(foo)\r\nfor index, constant in constantTable do\r\n    print(index, constant)\r\nend\n```",
        },
      },

      "debug.getinfo()": {
        "insertText": "debug.getinfo(${1:function}, ${2:what})",
        "documentation": {
          value: "```lua\nfunction debug.getinfo(function: function | number, what: string): table\n```\n\nReturns a table of information that\u0027s derived from a function or stack level.\\nTable fields: source (definition), short_src (truncated), linedefined (start line),\\nwhat (\\\"Lua\\\", \\\"C\\\", \\\"main\\\"), name, namewhat (scope), nups (upvalue count),\\nand func (function itself).\\n\n\nAlias: ``getinfo``\n\nParameters:\n- function: function | number - The function or stack level whose information is collected and returned.\n- what: string - Used to specify what information is returned in the table. Options include: \"n\" for name and namewhat, \"s\" for source and line details, \"l\" for currentline, and \"f\" for the function itself.\n\n### Example\n\n```lua\nfunction foo()\r\n    return \"Hello, world!\"\r\nend\r\n\r\nlocal functionInfo = debug.getinfo(foo)\r\nfor i, v in functionInfo do\r\n    print(i, v)\r\nend\n```",
        },
      },

      "debug.getproto()": {
        "insertText": "debug.getproto(${1:function}, ${2:index}, ${3:active})",
        "documentation": {
          value: "```lua\nfunction debug.getproto(function: function | number, index: number, active: boolean?): function | {function}\n```\n\nGets a cloned proto inside the \u0027func\u0027 unless the \u0027active\u0027 is specified which returns a table of all active protos.\n\nAlias: ``getproto``\n\nParameters:\n- function: function | number - The function or level you want to get the proto from.\n- index: number - The indice for the proto.\n- active: number - Return actively used protos instead of cloned ones.\n\n### Example\n\n```lua\nlocal function foo()\r\n\tlocal function bar()\r\n\t\tprint(\"foo\u0027s inner proto bar!\")\r\n\tend\r\nend\r\n\r\nlocal bar = debug.getproto(foo, 1, true)[1]\r\nbar() --\u003e foo\u0027s inner proto bar!\n```",
        },
      },

      "debug.getprotos()": {
        "insertText": "debug.getprotos(${1:function})",
        "documentation": {
          value: "```lua\nfunction debug.getprotos(function: function | number): {function}\n```\n\nReturn a list of all cloned protos.\n\nAlias: ``getprotos``\n\nParameters:\n- function: function | number - The function or level you want to get the protos from.\n\n### Example\n\n```lua\nlocal function foo()\r\n\tlocal function bar()\r\n\t\tprint(\"foo\u0027s inner proto bar!\")\r\n\tend\r\nend\r\n\r\nprint(debug.info(debug.getprotos(foo)[1], \"n\")) --\u003e bar\n```",
        },
      },

      "debug.getregistry()": {
        "insertText": "debug.getregistry()",
        "documentation": {
          value: "```lua\nfunction debug.getregistry(): { [any]: any }\n```\n\nReturns the global registry table. The registry is used to store references. Any object referenced in the registry will never be collected by the garbage collector, as the registry itself will never be collected. Thus a strong reference will always be held.\n\nAlias: ``getregistry``\n\n### Example\n\n```lua\nlocal registry = debug.getregistry()\r\nfor i, v in registry do\r\n    print(i, v)\r\nend\n```",
        },
      },

      "debug.getsafeenv()": {
        "insertText": "debug.getsafeenv(${1:object})",
        "documentation": {
          value: "```lua\nfunction debug.getsafeenv(object: function | table | thread)\n```\n\nReturns the safeenv flag.\n\nAlias: ``debug.isuntouched``\n\nParameters:\n- object: function | table | thread - The object you would like to get the safeenv of.\n\n### Example\n\n```lua\nprint(debug.getsafeenv()) --\u003e false\r\ndebug.setsafeenv(true)\r\nprint(debug.getsafeenv()) --\u003e true\r\n\r\n-- Since we are breaking safeenv protections by\r\n-- replacing a global function with getfenv, safeenv\r\n-- becomes false. Also applicable to setfenv.\r\ngetfenv().warn = function() end\r\nprint(debug.getsafeenv()) --\u003e false\n```",
        },
      },

      "debug.getstack()": {
        "insertText": "debug.getstack(${1:level}, ${2:index})",
        "documentation": {
          value: "```lua\nfunction debug.getstack(level: number, index: number?): ( any | { any } )\n```\n\nReturns a table (of the stack) or a singular object from the stack. Only returns objects that are currently on the stack.\n\nAlias: ``getstack``\n\nParameters:\n- level: number - The stack level at which the objects are collected.\n- index: number - The index of a specific object on the stack to return. If omitted, the entire stack at the given level is returned as a table.\n\n### Example\n\n```lua\n-- Imagine this is a hook of some kind.\r\nfunction foo(vec3)\r\n    local stack = debug.getstack(2)\r\n    for i, v in stack do\r\n        print(i, v)\r\n    end\r\nend\r\n\r\nlocal function bar()\r\n    local vec3 = Vector3.new()\r\n\r\n    foo(vec3)\r\n\r\n    return vec3\r\nend\r\n\r\nbar()\n```",
        },
      },

      "debug.getupvalue()": {
        "insertText": "debug.getupvalue(${1:function}, ${2:index})",
        "documentation": {
          value: "```lua\nfunction debug.getupvalue(function: function | number, index: number): any\n```\n\nReturns a singular upvalue that\u0027s derived from a function\u0027s upvalue list. Selected via index.\n\nAlias: ``getupvalue``\n\nParameters:\n- function: function | number - The function whose upvalue is returned.\n- index: number - The index of the upvalue to return.\n\n### Example\n\n```lua\nlocal bar = \"Hello, World!\"\r\nfunction foo()\r\n    print(bar)\r\nend\r\n\r\nlocal upvalue = debug.getupvalue(foo, 1)\r\nprint(upvalue)\n```",
        },
      },

      "debug.getupvalues()": {
        "insertText": "debug.getupvalues(${1:function})",
        "documentation": {
          value: "```lua\nfunction debug.getupvalues(function: function | number): { any }\n```\n\nReturns a table of upvalues from a function\u0027s upvalue\u0027s list.\n\nAlias: ``getupvalues``\n\nParameters:\n- function: function | number - The function whose upvalues are returned. Stack levels are also supported.\n\n### Example\n\n```lua\nlocal upvalue = \"Hello, World!\"\r\nfunction foo()\r\n    print(upvalue)\r\nend\r\n\r\nlocal upvalues = debug.getupvalues(foo)\r\nfor i, v in upvalues do\r\n    print(i, v)\r\nend\n```",
        },
      },

      "debug.isvalidlevel()": {
        "insertText": "debug.isvalidlevel(${1:level})",
        "documentation": {
          value: "```lua\nfunction debug.isvalidlevel(level: number)\n```\n\nChecks if \u0027level\u0027 is valid in the stack\n\nAlias: ``debug.validlevel``\n\nParameters:\n- level: number - The level you want to check.\n\n### Example\n\n```lua\nlocal function a()\r\n  print(debug.isvalidlevel(3))\r\nend\r\n\r\na() --\u003e false\r\nnewlclosure(a)() --\u003e true\n```",
        },
      },

      "debug.setconstant()": {
        "insertText": "debug.setconstant(${1:function}, ${2:index}, ${3:replacement})",
        "documentation": {
          value: "```lua\nfunction debug.setconstant(function: function | number, index: number, replacement: any): ()\n```\n\nSets a singular constant that\u0027s derived from a function. Selected via index.\n\nAlias: ``setconstant``\n\nParameters:\n- function: function | number - The function whose constant is set.\n- index: number - The index of the constant to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\nfunction foo()\r\n    return 696969420\r\nend\r\n\r\ndebug.setconstant(foo, 1, 0)\r\n\r\nprint(foo())\n```",
        },
      },

      "debug.setinfo()": {
        "insertText": "debug.setinfo(${1:func}, ${2:info})",
        "documentation": {
          value: "```lua\nfunction debug.setinfo(func: function, info: table): ()\n```\n\nSets the debug info around the \u0027func\u0027.\n\nAlias: ``setinfo``\n\nParameters:\n- func: function - The function you would like to change the info of\n- info: table - The info you would like to change. (name, source, short\\_src, currentline)\n\n### Example\n\n```lua\nlocal foo = function()\r\n  print(debug.traceback())\r\nend\r\n\r\nfoo() --\u003e Original info\r\n\r\ndebug.setinfo(foo, {\r\n  name = \"bar\",\r\n  source = \"bar\",\r\n  short_src = \"bar\",\r\n  currentline = 123\r\n})\r\n\r\nfoo() --\u003e Spoofed one\n```",
        },
      },

      "debug.setname()": {
        "insertText": "debug.setname(${1:function}, ${2:name})",
        "documentation": {
          value: "```lua\nfunction debug.setname(function: function | number, name: string): ()\n```\n\nChanges the function name specified to the set one.\n\nAlias: ``setname``\n\nParameters:\n- function: function | number - The function to set the name of.\n- name: number - The name you want to set the function to.\n\n### Example\n\n```lua\nlocal function foo()\r\n  print(\"name\", debug.info(1, \"n\"))\r\nend\r\n\r\nfoo() -- name foo\r\ndebug.setname(foo, \"bar\")\r\nfoo() -- name bar\n```",
        },
      },

      "debug.setsafeenv()": {
        "insertText": "debug.setsafeenv(${1:func}, ${2:safe})",
        "documentation": {
          value: "```lua\nfunction debug.setsafeenv(func: function | table | thread | boolean, safe: boolean?)\n```\n\nMarks the safeenv for an object.\n\nAlias: ``debug.setuntouched``\n\nParameters:\n- object: function | table | thread | boolean - The object you would like to set the safeenv of. (If a boolean is provided it will set the current state\u0027s safeenv)\n- safe: boolean - What to set the safeenv of the \u0027func\u0027.\n\n### Example\n\n```lua\nprint(debug.getsafeenv()) --\u003e false\r\ndebug.setsafeenv(true)\r\nprint(debug.getsafeenv()) --\u003e true\r\n\r\n-- Since we are breaking safeenv protections by\r\n-- replacing a global function with getfenv, safeenv\r\n-- becomes false. Also applicable to setfenv.\r\ngetfenv().warn = function() end\r\nprint(debug.getsafeenv()) --\u003e false\n```",
        },
      },

      "debug.setstack()": {
        "insertText": "debug.setstack(${1:level}, ${2:index}, ${3:replacement})",
        "documentation": {
          value: "```lua\nfunction debug.setstack(level: number, index: number, replacement: any): ()\n```\n\nSets a singular object from the stack.\n\nAlias: ``setstack``\n\nParameters:\n- level: number - The stack level of the function whose stack object is set.\n- index: number - The index of the stack object to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\n-- Imagine this is a hook of some kind.\r\nfunction foo(vec3)\r\n    local replacement = Vector3.new(100, 100, 100)\r\n    debug.setstack(2, 1, replacement)\r\nend\r\n\r\nlocal function bar()\r\n    local vec3 = Vector3.new()\r\n\r\n    foo(vec3)\r\n\r\n    return vec3\r\nend\r\n\r\nprint(bar())\n```",
        },
      },

      "debug.setupvalue()": {
        "insertText": "debug.setupvalue(${1:function}, ${2:index}, ${3:replacement})",
        "documentation": {
          value: "```lua\nfunction debug.setupvalue(function: function | number, index: number, replacement: any): ()\n```\n\nSets a singular upvalue that\u0027s derived from a function\u0027s upvalue list. Selected via index.\n\nAlias: ``setupvalue``\n\nParameters:\n- function: function | number - The function whose upvalue is set.\n- index: number - The index of the upvalue to set.\n- replacement: any - The replacement object. Must be of the same type.\n\n### Example\n\n```lua\nlocal upvalue = 0\r\n\r\nlocal function foo()\r\n    return upvalue\r\nend\r\n\r\nlocal function bar()\r\n    upvalue += 1\r\nend\r\n\r\nprint(foo())\r\n\r\ndebug.setupvalue(foo, 1, 10000)\r\n\r\nprint(foo())\n```",
        },
      },

      "decompile()": {
        "insertText": "decompile(${1:script})",
        "documentation": {
          value: "```lua\nfunction decompile(script: LuaSourceContainer): string\n```\n\nReturn pseudocode from the bytecode of \u0027LuaSourceContainer\u0027 with RunContext of \u0027Client\u0027, Legacy with a LocalScript or a ModuleScript.\n\nParameters:\n- script: LuaSourceContainer - The `LuaSourceContainer` (e.g. a `LocalScript` or `ModuleScript`) whose bytecode will be decompiled into pseudocode.\n\n### Example\n\n```lua\nlocal script = game:GetService(\"Players\").LocalPlayer.Character.Animate\r\n\r\nprint(decompile(script)) --\u003e Psuedocode of the bytecode from the script\n```",
        },
      },

      "delfile()": {
        "insertText": "delfile(${1:file})",
        "documentation": {
          value: "```lua\nfunction delfile(file: string): ()\n```\n\nDeletes the file from the specified \u0027path\u0027.\n\nParameters:\n- file: string - The file\u0027s path.\n\n### Example\n\n```lua\ndelfile(\"test.txt\")\n```",
        },
      },

      "delfolder()": {
        "insertText": "delfolder(${1:path})",
        "documentation": {
          value: "```lua\nfunction delfolder(path: string): ()\n```\n\nDeletes the folder from the specified \u0027path\u0027.\n\nParameters:\n- path: string - The path to the folder you want to delete\n\n### Example\n\n```lua\ndelfolder(\"mk\")\n```",
        },
      },

      "dofile()": {
        "insertText": "dofile(${1:file})",
        "documentation": {
          value: "```lua\nfunction dofile(file: string): ()\n```\n\nAttemps to execute contents from \u0027file\u0027.\n\nParameters:\n- file: string - The path to the file you\u0027re looking to load code from.\n\n### Example\n\n```lua\ndofile(\"test.txt\") -- Directly executes\n```",
        },
      },

      "Drawing.new()": {
        "insertText": "Drawing.new(${1:type})",
        "documentation": {
          value: "```lua\nfunction Drawing.new(type: string): DrawingObject\n```\n\nCreate a new drawing object of the specified type.\n\nParameters:\n- type: string - The type of drawing object to create.\n\n### Example\n\n```lua\nlocal circle = Drawing.new(\"Circle\")\r\ncircle.Radius = 50\r\ncircle.Color = Color3.fromRGB(255, 0, 0)\r\ncircle.Filled = true\r\ncircle.NumSides = 32\r\ncircle.Position = Vector2.new(300, 300)\r\ncircle.Transparency = 0.7\r\ncircle.Visible = true\r\n\r\ntask.wait(1)\r\ncircle:Destroy()\n```",
        },
      },

      "DrawingImmediate.GetPaint()": {
        "insertText": "DrawingImmediate.GetPaint(${1:zindex})",
        "documentation": {
          value: "```lua\nfunction DrawingImmediate.GetPaint(zindex: int): PsmSignal\n```\n\nReturns an event that is fired every render step for a specific `zindex`. Lower value `zindex` events will fire before higher value events. DrawingImmediate.* APIs can only be called under these events.\n\nParameters:\n- zindex: int - The zindex that the event will fire on.\n\n### Example\n\n```lua\nlocal signal = DrawingImmediate.GetPaint(1)\r\nlocal uis = game:GetService(\"UserInputService\")\r\n\r\nsignal:Connect(function()\r\n    local mousepos = uis:GetMouseLocation()\r\n\r\n    DrawingImmediate.Circle(mousepos, 100, Color3.new(1, 1, 1), 1, 100, 1)\r\nend)\n```",
        },
      },

      "filtergc()": {
        "insertText": "filtergc(${1:filterType}, ${2:filterOptions}, ${3:filterOne})",
        "documentation": {
          value: "```lua\nfunction filtergc(filterType: string, filterOptions: table, filterOne: boolean): {any} | any?\n```\n\nReturns a table of objects filtered from the garbage collection list. If specified, a single object can also be filtered and returned instead.\n\nParameters:\n- filterType: string - The specific type to filter for. \"function\" or \"table\" are the only accepted strings. Each filter type has it\u0027s own filter options.\n- filterOptions: table - Filter options. See corresponding usage in example below.\n- filterOne: boolean - Boolean indicating whether to return a singular object.\n\n### Example\n\n```lua\nlocal function exampleFunction()\n    return \"Hello, world!\"\r\nend\n\nlocal filterOptions = {\r\n    IgnoreExecutor = false,\r\n    Name = \"exampleFunction\"\n}\n\nlocal result = filtergc(\"function\", filterOptions, true)\nprint(exampleFunction == found) --\u003e true\nprint(result()) --\u003e Hello, world!\n```",
        },
      },

      "fireclickdetector()": {
        "insertText": "fireclickdetector(${1:clickdetector}, ${2:distance}, ${3:signal})",
        "documentation": {
          value: "```lua\nfunction fireclickdetector(clickdetector: ClickDetector, distance?: number, signal?: string): ()\n```\n\nFires a `ClickDetector`\u0027s signal.\n\nParameters:\n- clickdetector: ClickDetector - The `ClickDetector` that\u0027s fired.\n- distance: number - The distance between the `LocalPlayer` and the `ClickDetector`\u0027s parent part. The default distance is 0.\n- signal: string - This string determines which signal to fire. Signal types include: \"MouseClick\", \"RightMouseClick\", \"MouseHoverEnter\", and \"MouseHoverLeave\". The Default is \"MouseClick\".\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\")\r\nlocal clickdetector = Instance.new(\"ClickDetector\", part)\r\n\r\nclickdetector.MouseClick:Connect(function()\r\n    print(\"fired MouseClick\")\r\nend)\r\n\r\nclickdetector.RightMouseClick:Connect(function()\r\n    print(\"fired RightMouseClick\")\r\nend)\r\n\r\nfireclickdetector(clickdetector) -- Will fire \"MouseClick\"\r\ntask.wait(1)\r\nfireclickdetector(clickdetector, 0, \"RightMouseClick\")\n```",
        },
      },

      "fireproximityprompt()": {
        "insertText": "fireproximityprompt(${1:proximityprompt})",
        "documentation": {
          value: "```lua\nfunction fireproximityprompt(proximityprompt: ProximityPrompt): ()\n```\n\nFires the `ProximityPrompt`\u0027s `Triggered` signal.\n\nParameters:\n- proximityprompt: ProximityPrompt - The `ProximityPrompt` that\u0027s triggered.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\", workspace)\r\nlocal proximityPrompt = Instance.new(\"ProximityPrompt\", part)\r\n\r\nproximityPrompt.Triggered:Connect(function()\r\n    print(\"proximityPrompt Triggered\")\r\nend)\r\n\r\nfireproximityprompt(proximityPrompt)\n```",
        },
      },

      "firesignal()": {
        "insertText": "firesignal(${1:signal}, ${2:...: any?})",
        "documentation": {
          value: "```lua\nfunction firesignal(signal: RBXScriptSignal, ...: any?)\n```\n\nFires all connections connected to a `RBXScriptSignal`.\n\nParameters:\n- signal: RBXScriptSignal - The specific signal to fire.\n\n### Example\n\n```lua\nlocal localPlayer = game.Players.LocalPlayer\r\n\r\nlocalPlayer.Idled:Connect(function()\r\n    print(\"Fired!\")\r\nend)\r\n\r\nfiresignal(localPlayer.Idled)\n```",
        },
      },

      "firetouchinterest()": {
        "insertText": "firetouchinterest(${1:source}, ${2:target}, ${3:touch})",
        "documentation": {
          value: "```lua\nfunction firetouchinterest(source: Instance, target: Instance, touch: boolean): ()\n```\n\nFires an `Instance`\u0027s `Touched` and `TouchEnded` signals.\n\nParameters:\n- source: Instance - The `Instance` that will touch the target.\n- target: Instance - The `Instance` that will be touched by the source.\n- touch: boolean - This boolean toggles between touching and not touching the target `Instance`.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\", workspace)\r\n\r\npart.Touched:Connect(function()\r\n    print(\"Touched\")\r\nend)\r\n\r\npart.TouchEnded:Connect(function()\r\n    print(\"TouchEnded\")\r\nend)\r\n\r\nlocal character = game.Players.LocalPlayer.Character\r\n\r\nfiretouchinterest(part, character.HumanoidRootPart, true)\r\ntask.wait(1)\r\n\r\nfiretouchinterest(part, character.HumanoidRootPart, false)\r\ntask.wait()\r\n\r\npart:Destroy()\n```",
        },
      },

      "get_comm_channel()": {
        "insertText": "get_comm_channel(${1:id})",
        "documentation": {
          value: "```lua\nfunction get_comm_channel(id: number): BindableEvent\n```\n\nReturns a `BindableEvent`. Used in one-way communication between actors.\n\nParameters:\n- id: number - The `id` used in obtaining the corresponding channel.\n\n### Example\n\n```lua\nlocal id, channel = create_comm_channel()\r\nchannel.Event:Connect(function(data)\r\n    print(data)\r\nend)\r\n\r\nrun_on_actor(getactors()[1], [[\r\n    local id = ...\r\n    local channel = get_comm_channel(id)\r\n    channel:Fire(\"Hello, World!\")\r\n]], id)\n```",
        },
      },

      "getactors()": {
        "insertText": "getactors()",
        "documentation": {
          value: "```lua\nfunction getactors(): {Actor}\n```\n\nReturns a table of `actor` (not including deleted ones). Some games delete their actors while they\u0027re running.\n\nAlias: ``get_actors``\n\n### Example\n\n```lua\nfor _, actor in getactors() do\r\n    print(actor)\r\nend\n```",
        },
      },

      "getactorthreads()": {
        "insertText": "getactorthreads()",
        "documentation": {
          value: "```lua\nfunction getactorthreads(): {thread}\n```\n\nReturns a table of every thread connected to every actor.\n\nAlias: ``get_actor_threads``\n\n### Example\n\n```lua\nfor _, actorThread in getactorthreads() do\r\n    print(actorThread)\r\nend\n```",
        },
      },

      "getbspval()": {
        "insertText": "getbspval(${1:instance}, ${2:property}, ${3:base64})",
        "documentation": {
          value: "```lua\nfunction getbspval(instance: Instance, property: string, base64: boolean): string\n```\n\nReads a `BinaryString` propertyâ€™s value. Useful for reading conventionally unreadable `BinaryString` properties such as Terrain.SmoothGrid, PartOperation.PhysicsData, BinaryStringValue.Value, and so on.\n\nParameters:\n- instance: Instance - The `Instance` that contains the `BinaryString`\u0027s value.\n- property: string - The name of the property read.\n- base64: boolean - Boolean indicating whether the `BinaryString`\u0027s value is Base64 encoded.\n\n### Example\n\n```lua\nlocal result = getbspval(workspace.Terrain, \"SmoothGrid\", true)\r\nprint(result) --\u003e AQU= (Example output)\n```",
        },
      },

      "getcallbackvalue()": {
        "insertText": "getcallbackvalue(${1:instance}, ${2:property})",
        "documentation": {
          value: "```lua\nfunction getcallbackvalue(instance: Instance, property: string): function?\n```\n\nReturns a callback function associated with a callback property.\n\nAlias: ``getcallbackmember``\n\nParameters:\n- instance: Instance - The `Instance` that is used to derive the callback.\n- property: string - The name of the callback property. See example below.\n\n### Example\n\n```lua\nlocal bindableFunction = Instance.new(\"BindableFunction\")\r\nbindableFunction.OnInvoke = function()\r\n    print(\"Invoked\")\r\nend\r\n\r\nlocal callback = getcallbackvalue(bindableFunction, \"OnInvoke\")\r\ncallback() --\u003e Invoked\n```",
        },
      },

      "getconnection()": {
        "insertText": "getconnection(${1:signal}, ${2:index})",
        "documentation": {
          value: "```lua\nfunction getconnection(signal: RBXScriptSignal, index: number): {Connection}\n```\n\nReturns a `Connection` object that is connected to a given `RBXScriptSignal`.\n\nParameters:\n- signal: RBXScriptSignal - The specific signal to use.\n- index: number - The specific signal to grab using the index provided.\n\n### Example\n\n```lua\nlocal connection = getconnection(game.Players.LocalPlayer.Idled, 1)\r\nconnection:Disable()\n```",
        },
      },

      "getconnections()": {
        "insertText": "getconnections(${1:signal})",
        "documentation": {
          value: "```lua\nfunction getconnections(signal: RBXScriptSignal): {Connection}\n```\n\nReturns a table of `Connection` objects that are connected to a given `RBXScriptSignal`.\n\nParameters:\n- signal: RBXScriptSignal - The specific signal to use.\n\n### Example\n\n```lua\nlocal connection = getconnections(game.Players.LocalPlayer.Idled)[1]\r\nconnection:Disable()\n```",
        },
      },

      "getcustomasset()": {
        "insertText": "getcustomasset(${1:filepath})",
        "documentation": {
          value: "```lua\nfunction getcustomasset(filepath: string): string\n```\n\nReturns an asset ID that can be used in loading custom assets.\n\nParameters:\n- file: string - The file path from the `workspace` folder.\n\n### Example\n\n```lua\nlocal assetId = getcustomasset(\"mysound.mp3\")\r\n\r\nlocal sound = Instance.new(\"Sound\", workspace)\r\nsound.SoundId = assetId\r\nsound:Play()\n```",
        },
      },

      "getdeletedactors()": {
        "insertText": "getdeletedactors()",
        "documentation": {
          value: "```lua\nfunction getdeletedactors(): {Actor}\n```\n\nReturns a table of every deleted actor. Some games delete their actors while they\u0027re running.\n\nAlias: ``get_deleted_actors``\n\n### Example\n\n```lua\nfor _, deletedActor in getdeletedactors() do\r\n    print(deletedActor)\r\nend\n```",
        },
      },

      "getfflag()": {
        "insertText": "getfflag(${1:fflag})",
        "documentation": {
          value: "```lua\nfunction getfflag(fflag: string): string\n```\n\nReturns the value of a Fast Flag.\n\nAlias: ``getfastflag``\n\n### Example\n\n```lua\nlocal fps = getfflag(\"TaskSchedulerTargetFps\")\nprint(\"Current FPS cap:\", fps)\n\nlocal dpiFix = getfflag(\"FixDPIScaling\")\nprint(\"DPI fix enabled:\", dpiFix)\n```",
        },
      },

      "getfflagtype()": {
        "insertText": "getfflagtype(${1:fflag})",
        "documentation": {
          value: "```lua\nfunction getfflagtype(fflag: string): string\n```\n\nGets the type of a Fast Flag.\n\nAlias: ``getfastflagtype``\n\n### Example\n\n```lua\nprint(getfflagtype(\"TaskSchedulerTargetFps\")) --\u003e int\nprint(getfflagtype(\"AddClassFullName\")) --\u003e flag\n```",
        },
      },

      "getfpscap()": {
        "insertText": "getfpscap()",
        "documentation": {
          value: "```lua\nfunction getfpscap(): number\n```\n\nReturns the fps cap set by the client.\n\n### Example\n\n```lua\nprint(getfpscap()) --\u003e 60\n```",
        },
      },

      "getfunctionhash()": {
        "insertText": "getfunctionhash(${1:func})",
        "documentation": {
          value: "```lua\nfunction getfunctionhash(func: function): string\n```\n\nReturns the hash of a lua function.\n\nParameters:\n- func: function - The `function` to hash.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nlocal function bar(x, y)\r\n    return x + y\r\nend\r\n\r\nlocal firstHash = getfunctionhash(foo)\r\nlocal secondHash = getfunctionhash(bar)\r\n\r\nprint(firstHash == secondHash) --\u003e false\n```",
        },
      },

      "getgc()": {
        "insertText": "getgc(${1:includeTables})",
        "documentation": {
          value: "```lua\nfunction getgc(includeTables: boolean?): {any}\n```\n\nReturns a table of objects from the garbage collection list. If specified, tables will be included.\n\nParameters:\n- includeTables: boolean - If true, all tables will be included.\n\n### Example\n\n```lua\nfor _, object in getgc() do\r\n    if type(object) == \"function\" and isexecutorclosure(object) then\r\n        print(object)\r\n    end\r\nend\n```",
        },
      },

      "getgenv()": {
        "insertText": "getgenv()",
        "documentation": {
          value: "```lua\nfunction getgenv(): { any }\n```\n\nReturns the global environment table, which is shared across all potassium-made threads. This table is commonly used to share or store information between different potassium-executed scripts.\n\n### Example\n\n```lua\nlocal alreadyRan = getgenv().alreadyRan\r\n\r\nif alreadyRan then\r\n    print(\"Already ran!\")\r\nelse\r\n    print(\"Hello, world!\")\r\n    getgenv().alreadyRan = true\r\nend\n```",
        },
      },

      "gethiddenproperties()": {
        "insertText": "gethiddenproperties(${1:instance})",
        "documentation": {
          value: "```lua\nfunction gethiddenproperties(instance: Instance): { property: value }\n```\n\nReturns a table of every non-scriptable property and its value.\n\n### Example\n\n```lua\nfor property, value in gethiddenproperties(workspace) do\r\n    print(property, value);\r\nend\n```",
        },
      },

      "gethiddenproperty()": {
        "insertText": "gethiddenproperty(${1:instance}, ${2:propertyname})",
        "documentation": {
          value: "```lua\nfunction gethiddenproperty(instance: Instance, propertyname: string): (any, boolean)\n```\n\nReturns the value of a hidden property, and a boolean indicating whether the property is hidden.\n\nAlias: ``gethiddenprop``\n\nParameters:\n- instance: Instance - The `Instance` that contains the hidden property.\n- propertyname: string - The name of the property returned.\n\n### Example\n\n```lua\nlocal fire = Instance.new(\"Fire\")\r\n\r\nlocal size_xml, hidden = gethiddenproperty(fire, \"size_xml\")\r\nprint(size_xml, hidden)\n```",
        },
      },

      "gethui()": {
        "insertText": "gethui()",
        "documentation": {
          value: "```lua\nfunction gethui(): Instance\n```\n\nReturns a container that\u0027s hidden from game scripts.\n\nAlias: ``get_hidden_gui``\n\n### Example\n\n```lua\nlocal hiddenContainer = gethui()\r\n\r\nlocal frame = Instance.new(\"Frame\", hiddenContainer)\r\nframe.Size = UDim2.new(0, 100, 0, 100)\n```",
        },
      },

      "gethwid()": {
        "insertText": "gethwid()",
        "documentation": {
          value: "```lua\nfunction gethwid(): string\n```\n\nReturns a unique string for the users device.\n\n### Example\n\n```lua\nprint(\"HWID:\", gethwid())\n```",
        },
      },

      "getinstances()": {
        "insertText": "getinstances()",
        "documentation": {
          value: "```lua\nfunction getinstances(): { Instance }\n```\n\nReturns a table of every instance in the game.\n\n### Example\n\n```lua\nfor _, instance in getinstances() do\r\n    print(instance)\r\nend\n```",
        },
      },

      "getloadedmodules()": {
        "insertText": "getloadedmodules()",
        "documentation": {
          value: "```lua\nfunction getloadedmodules(): { ModuleScript }\n```\n\nReturns a table of every `ModuleScript` that\u0027s loaded in the game.\n\n### Example\n\n```lua\nfor _, script in getloadedmodules() do\r\n    if script.Name == \"PlayerModule\" then\r\n        print(script:GetFullName())\r\n    end\r\nend\n```",
        },
      },

      "getnamecallmethod()": {
        "insertText": "getnamecallmethod()",
        "documentation": {
          value: "```lua\nfunction getnamecallmethod(): string?\n```\n\nGets the current thread\u0027s `__namecall` method.\n\nAlias: ``get_namecall_method``\n\n### Example\n\n```lua\nxpcall(function()\r\n  return game:method()\r\nend, function()\r\n  print(getnamecallmethod()) --\u003e method\r\nend)\n```",
        },
      },

      "getnilinstances()": {
        "insertText": "getnilinstances()",
        "documentation": {
          value: "```lua\nfunction getnilinstances(): { Instance }\n```\n\nReturns a table of every instance in the game that is parented to nil.\n\n### Example\n\n```lua\nfor _, instance in getnilinstances() do\r\n    print(instance)\r\nend\n```",
        },
      },

      "getobjects()": {
        "insertText": "getobjects(${1:self}, ${2:asset})",
        "documentation": {
          value: "```lua\nfunction getobjects(self: any?, asset: string): ()\n```\n\nEquivalent for game:GetObjects by fetching `asset` from Roblox.\n\nParameters:\n- self: any - An optional legacy first argument (e.g. `game`) used for backwards compatibility. When provided, the second `asset` argument is used as the asset identifier.\n- asset: string - The `rbxassetid://` URL of the Roblox asset to fetch and load.\n\n### Example\n\n```lua\nlocal asset = getobjects(\"rbxassetid://1818\") --\u003e Fetches Crossroads\r\n\r\nprint(asset[1]) --\u003e SoundService\n```",
        },
      },

      "getpcd()": {
        "insertText": "getpcd(${1:trianglemeshpart})",
        "documentation": {
          value: "```lua\nfunction getpcd(trianglemeshpart: Instance): string, string\n```\n\nReturns a 16-byte hash and binary data corresponding to TriangleMeshPartâ€™s PhysicalConfigData property.\n\nAlias: ``getpcdprop``\n\nParameters:\n- trianglemeshpart: Instance - The `Instance` that contains the binary data.\n\n### Example\n\n```lua\nprint(getpcd(Instance.new(\"UnionOperation\")))\n```",
        },
      },

      "getproperties()": {
        "insertText": "getproperties(${1:instance})",
        "documentation": {
          value: "```lua\nfunction getproperties(instance: Instance): { property: value }\n```\n\nReturns a table of every property, including non-scriptable properties and its value.\n\n### Example\n\n```lua\nfor property, value in getproperties(workspace) do\r\n    print(property, value)\r\nend\n```",
        },
      },

      "getproximitypromptduration()": {
        "insertText": "getproximitypromptduration(${1:proximityprompt})",
        "documentation": {
          value: "```lua\nfunction getproximitypromptduration(proximityprompt: ProximityPrompt): number\n```\n\nReturns the value of a proximity prompt\u0027s duration.\n\nParameters:\n- proximityprompt: ProximityPrompt - The `ProximityPrompt` that contains the duration.\n\n### Example\n\n```lua\nlocal proximityprompt = Instance.new(\"ProximityPrompt\")\r\nproximityprompt.HoldDuration = 3\r\n\r\nlocal duration = getproximitypromptduration(proximityprompt)\r\nprint(duration)\n```",
        },
      },

      "getrawmetatable()": {
        "insertText": "getrawmetatable(${1:meta})",
        "documentation": {
          value: "```lua\nfunction getrawmetatable(meta: table | userdata): table?\n```\n\nGets the \u0027metatable\u0027 from a table or userdata whilst ignoring the `__metatable` value.\n\nAlias: ``debug.getmetatable``\n\nParameters:\n- meta: table | userdata - The table or userdata that contains a metatable.\n\n### Example\n\n```lua\nlocal t = setmetatable({}, {\r\n  __index = function(self, index)\r\n      print(index)\r\n  end,\r\n  __metatable = \"This table is locked.\"\r\n})\r\n\r\nprint(getmetatable(t)) --\u003e This table is locked.\r\nprint(getrawmetatable(t)) --\u003e table: 0x.....\n```",
        },
      },

      "getreg()": {
        "insertText": "getreg()",
        "documentation": {
          value: "```lua\nfunction getreg(): { [any]: any }\n```\n\nReturns the global registry table. The registry is used to store references. Any object referenced in the registry will never be collected by the garbage collector, as the registry itself will never be collected. Thus a strong reference will always be held.\n\n### Example\n\n```lua\nlocal registry = getreg()\r\nfor i, v in registry do\r\n    print(i, v)\r\nend\n```",
        },
      },

      "getrenderproperty()": {
        "insertText": "getrenderproperty(${1:drawing}, ${2:property})",
        "documentation": {
          value: "```lua\nfunction getrenderproperty(drawing: DrawingObject, property: string): any\n```\n\nGets a property value from a `DrawingObject`.\n\nParameters:\n- drawing: DrawingObject - The drawing object to retrieve the property from.\n- property: string - The property to retrieve.\n\n### Example\n\n```lua\nlocal circle = Drawing.new(\"Circle\")\r\n\r\nprint(\"Radius:\", getrenderproperty(circle, \"Radius\"))\n```",
        },
      },

      "getrendersteppedlist()": {
        "insertText": "getrendersteppedlist()",
        "documentation": {
          value: "```lua\nfunction getrendersteppedlist(): { function }\n```\n\nReturns a table of every callback that\u0027s bound using `BindToRenderStep`.\n\n### Example\n\n```lua\nlocal connections = getrendersteppedlist()\r\n\r\nfor _, callback in connections do\r\n    print(\"Function:\", callback.Function)\r\n    print(\"Thread:\", callback.Thread)\r\n    print(\"Priority:\", callback.Priority)\r\n    print(\"Name:\", callback.Name)\r\nend\n```",
        },
      },

      "getrenv()": {
        "insertText": "getrenv()",
        "documentation": {
          value: "```lua\nfunction getrenv(): { any }\n```\n\nReturns the roblox\u0027s global environment table, which is inherited by all threads.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = hookfunction(getrenv().require, function(...)\r\n    print(...)\r\n    return old(...)\r\nend)\n```",
        },
      },

      "getrunningscripts()": {
        "insertText": "getrunningscripts()",
        "documentation": {
          value: "```lua\nfunction getrunningscripts(): { BaseScript }\n```\n\nReturns a table of every script that\u0027s currently running.\n\n### Example\n\n```lua\nfor _, script in getrunningscripts() do\r\n    if script.Name == \"Animate\" then\r\n        print(script.Parent.Name)\r\n    end\r\nend\n```",
        },
      },

      "getscriptbytecode()": {
        "insertText": "getscriptbytecode(${1:script})",
        "documentation": {
          value: "```lua\nfunction getscriptbytecode(script: BaseScript): string\n```\n\nReturns the bytecode of a given script.\n\nAlias: ``dumpstring``\n\nParameters:\n- script: BaseScript - The script that will have it\u0027s bytecode returned.\n\n### Example\n\n```lua\nfor _, script in getrunningscripts() do\r\n    if script.Name == \"Animate\" then\r\n        print(getscriptbytecode(script))\r\n    end\r\nend\n```",
        },
      },

      "getscriptclosure()": {
        "insertText": "getscriptclosure(${1:script})",
        "documentation": {
          value: "```lua\nfunction getscriptclosure(script: BaseScript): function\n```\n\nReturns the main function of a given script.\n\nAlias: ``getscriptfunction``\n\nParameters:\n- script: BaseScript - The script that will have it\u0027s main function returned.\n\n### Example\n\n```lua\nfor _, script in getrunningscripts() do\r\n    print(getscriptclosure(script))\r\nend\n```",
        },
      },

      "getscriptfromthread()": {
        "insertText": "getscriptfromthread(${1:thread})",
        "documentation": {
          value: "```lua\nfunction getscriptfromthread(thread: thread): BaseScript?\n```\n\nReturns a script (or nil) that\u0027s derived from an associated thread.\n\nParameters:\n- thread: thread - User provided thread.\n\n### Example\n\n```lua\nfor _, thread in getallthreads() do\r\n    local script = getscriptfromthread(thread)\r\n    if script then\r\n        print(script)\r\n    end\r\nend\n```",
        },
      },

      "getscripthash()": {
        "insertText": "getscripthash(${1:script})",
        "documentation": {
          value: "```lua\nfunction getscripthash(script: BaseScript): string\n```\n\nReturns a hash of a given script.\n\nParameters:\n- script: BaseScript - The script that will be hashed.\n\n### Example\n\n```lua\nfor _, script in getrunningscripts() do\r\n    print(getscripthash(script))\r\nend\n```",
        },
      },

      "getscripts()": {
        "insertText": "getscripts()",
        "documentation": {
          value: "```lua\nfunction getscripts(): { BaseScript }\n```\n\nReturns a table of every script in the game.\n\n### Example\n\n```lua\nfor _, script in getscripts() do\r\n    print(script)\r\nend\n```",
        },
      },

      "getscriptthread()": {
        "insertText": "getscriptthread(${1:script})",
        "documentation": {
          value: "```lua\nfunction getscriptthread(script: BaseScript): thread?\n```\n\nReturns a thread (or nil) that\u0027s derived from an associated script.\n\nParameters:\n- script: BaseScript - The script that will have it\u0027s thread returned.\n\n### Example\n\n```lua\nfor _, script in getnilinstances() do\r\n    if not script:IsA(\"LocalScript\") then\r\n        continue\r\n    end\r\n\r\n    local thread = getscriptthread(script);\r\n\r\n    if thread and coroutine.status(thread) ~= \"dead\" then\r\n        task.cancel(thread)\r\n    end\r\nend\n```",
        },
      },

      "getsenv()": {
        "insertText": "getsenv(${1:script})",
        "documentation": {
          value: "```lua\nfunction getsenv(script: Script): { [any]: any }?\n```\n\nReturns the global environment table of a `Script`, `LocalScript`, or `ModuleScript`.\n\nParameters:\n- script: Script - Can be a `LocalScript`, `ModuleScript` or a `Script` (if it\u0027s `RunContext` is `Client`). The script must be running.\n\n### Example\n\n```lua\nlocal script = getrunningscripts()[1]\r\ntable.foreach(getsenv(script), print)\n```",
        },
      },

      "getsignalarguments()": {
        "insertText": "getsignalarguments(${1:signal})",
        "documentation": {
          value: "```lua\nfunction getsignalarguments(signal: RBXScriptSignal): { string }\n```\n\nReturns a table of expected argument types for a given `RBXScriptSignal`.\n\nParameters:\n- signal: RBXScriptSignal - The signal that will have it\u0027s arguments derived from.\n\n### Example\n\n```lua\nlocal signal = game.Players.LocalPlayer.Idled\r\nlocal signalArguments = getsignalarguments(signal)\r\n\r\nfor _, argument in signalArguments do\r\n    print(argument)\r\nend\n```",
        },
      },

      "getsignalargumentsinfo()": {
        "insertText": "getsignalargumentsinfo(${1:signal})",
        "documentation": {
          value: "```lua\nfunction getsignalargumentsinfo(signal: RBXScriptSignal): { ArgumentInfo }\n```\n\nReturns a table of expected argument information for a given `RBXScriptSignal`. You can use this information to replicate signals.\n\nParameters:\n- signal: RBXScriptSignal - The signal that will have it\u0027s arguments derived from.\n\n### Example\n\n```lua\nlocal signal = game.Players.LocalPlayer.Idled\r\nlocal signalArgumentInfo = getsignalargumentsinfo(signal)\r\n\r\nfor _, argumentInfo in signalArgumentInfo do\r\n    print(argumentInfo)\r\nend\n```",
        },
      },

      "getsignalwhitelist()": {
        "insertText": "getsignalwhitelist()",
        "documentation": {
          value: "```lua\nfunction getsignalwhitelist(): { SignalWhitelistInfo }\n```\n\nReturns a table of `SignalWhitelistInfo` objects that are in Roblox\u0027s replication whitelist.\n\n### Example\n\n```lua\nlocal whitelist = getsignalwhitelist()\r\nfor _, signal in whitelist do\r\n    print(string.format(\"%s.%s\", signal.Parent, signal.Event))\r\nend\n```",
        },
      },

      "getsimulationradius()": {
        "insertText": "getsimulationradius()",
        "documentation": {
          value: "```lua\nfunction getsimulationradius(): number\n```\n\nReturns the simulation radius of the `LocalPlayer`.\n\n### Example\n\n```lua\nprint(getsimulationradius()) --\u003e 1000\r\nsetsimulationradius(2000)\r\nprint(getsimulationradius()) --\u003e 2000\n```",
        },
      },

      "gettenv()": {
        "insertText": "gettenv(${1:thread})",
        "documentation": {
          value: "```lua\nfunction gettenv(thread: thread?): { any }\n```\n\nReturns a thread\u0027s environment table.\n\nParameters:\n- thread: thread - The thread that will be used. If not specified, it will default to the current thread.\n\n### Example\n\n```lua\nlocal thread = coroutine.create(function() end)\r\ntable.foreach(gettenv(thread), print)\n```",
        },
      },

      "getthreadidentity()": {
        "insertText": "getthreadidentity()",
        "documentation": {
          value: "```lua\nfunction getthreadidentity(): number\n```\n\nReturns the current thread\u0027s identity.\n\n### Example\n\n```lua\nprint(getthreadidentity()) --\u003e 8 (without previous changes)\n```",
        },
      },

      "hookfunction()": {
        "insertText": "hookfunction(${1:target}, ${2:hook})",
        "documentation": {
          value: "```lua\nfunction hookfunction(target: function, hook: function): function\n```\n\nHooks a Lua or C function. Returns a copy of the original function.\n\nParameters:\n- target: function - The `function` to hook.\n- hook: function - The `function` to call instead.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = hookfunction(print, function(...)\r\n    if select(1, ...) == \"Hello, world!\" then\r\n        return warn(...)\r\n    end\r\n\r\n    return old(...)\r\nend)\r\n\r\nprint(\"Hello, world!\") -- This will be a warning.\r\nprint(\"Goodbye, world!\") -- This will be a print.\n```",
        },
      },

      "hookmetamethod()": {
        "insertText": "hookmetamethod(${1:object}, ${2:method}, ${3:hook})",
        "documentation": {
          value: "```lua\nfunction hookmetamethod(object: Instance | table | userdata, method: string, hook: function): table?\n```\n\nhooks the `method` inside the `object` with `func` returning the old func.\n\nParameters:\n- object: Instance | table | userdata - The object that contains a metatable.\n- method: string - A metatable method.\n- hook: function - The function that will hook the \u0027method\u0027 function.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = hookmetamethod(game, \"__newindex\", function(self, index, value)\r\n  if not checkcaller() then --\u003e Ignore non-executor newindex calls\r\n      return old(self, index, value)\r\n  end\r\n\r\n  if value == game then --\u003e Prevent any changes from being made to game\r\n      return nil\r\n  end\r\n\r\n  return old(self, index, value)\r\nend)\r\n\r\nlocal objectValue = Instance.new(\"ObjectValue\")\r\nobjectValue.Value = workspace\r\nprint(objectValue.Value) --\u003e Workspace\r\n\r\nobjectValue.Value = game\r\nprint(objectValue.Value) --\u003e Workspace\n```",
        },
      },

      "httpget()": {
        "insertText": "httpget(${1:self}, ${2:url})",
        "documentation": {
          value: "```lua\nfunction httpget(self: any?, url: string): ()\n```\n\nHTTP GET request to `url`.\n\nAlias: ``HttpGet``\n\nParameters:\n- self: any - An optional legacy first argument (e.g. `game`) used for backwards compatibility. When provided, the second `url` argument is used as the request target.\n- url: string - The URL to send the HTTP GET request to.\n\n### Example\n\n```lua\nprint(httpget(\"https://httpbin.org/get\")) --\u003e HTTP body\r\n\r\n-- Backwards compatibility but functions exactly the same\r\nprint(httpget(game, \"https://httpbin.org/get\")) --\u003e HTTP body\n```",
        },
      },

      "identifyexecutor()": {
        "insertText": "identifyexecutor()",
        "documentation": {
          value: "```lua\nfunction identifyexecutor(): (string, string)\n```\n\nReturns information about the executor alongside its version.\n\nAlias: ``getexecutorname``\n\n### Example\n\n```lua\nprint(identifyexecutor()) --\u003e Ex: Potassium, v1.0.0\n```",
        },
      },

      "Introduction()": {
        "insertText": "Introduction($0)",
        "documentation": {
          value: "This is the official documentation for Potassium.",
        },
      },

      "is_parallel()": {
        "insertText": "is_parallel()",
        "documentation": {
          value: "```lua\nfunction is_parallel(): boolean\n```\n\nReturns a boolean indicating whether `is_parallel` was called in parallel.\n\n### Example\n\n```lua\nprint(is_parallel()) --\u003e false\r\n\r\nrun_on_actor(getactors()[1], [[\r\n    print(is_parallel())\r\n]]) --\u003e true\n```",
        },
      },

      "iscclosure()": {
        "insertText": "iscclosure(${1:func})",
        "documentation": {
          value: "```lua\nfunction iscclosure(func: function): boolean\n```\n\nReturns a boolean indicating whether the function is a C closure.\n\nParameters:\n- func: function - The `function` to evaluate.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nprint(iscclosure(foo)) --\u003e false\r\nprint(iscclosure(print)) --\u003e true\n```",
        },
      },

      "isexecutorclosure()": {
        "insertText": "isexecutorclosure(${1:func})",
        "documentation": {
          value: "```lua\nfunction isexecutorclosure(func: function): boolean\n```\n\nReturns a boolean indicating whether the function has been created by Potassium.\n\nParameters:\n- func: function - The `function` to evaluate.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nprint(isexecutorclosure(foo)) --\u003e true\r\nprint(isexecutorclosure(print)) --\u003e false\n```",
        },
      },

      "isfile()": {
        "insertText": "isfile(${1:path})",
        "documentation": {
          value: "```lua\nfunction isfile(path: string): boolean\n```\n\nChecks if specified \u0027path\u0027 is a file.\n\nParameters:\n- path: string - The path to the potentional file\n\n### Example\n\n```lua\nwritefile(\"test\", \"hello!\")\r\nprint(isfile(\"test\")) -- true\n```",
        },
      },

      "isfolder()": {
        "insertText": "isfolder(${1:path})",
        "documentation": {
          value: "```lua\nfunction isfolder(path: string): boolean\n```\n\nChecks if specified \u0027path\u0027 is a folder.\n\nParameters:\n- path: string - The path you want to check\n\n### Example\n\n```lua\nwritefile(\"test\", \"hello!\")\r\nprint(isfolder(\"test\")) --\u003e false\n```",
        },
      },

      "isfunctionhooked()": {
        "insertText": "isfunctionhooked(${1:target})",
        "documentation": {
          value: "```lua\nfunction isfunctionhooked(target: function): boolean\n```\n\nReturns a boolean indicating whether the function has been hooked.\n\nParameters:\n- target: function - The `function` to evaluate.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nprint(\"Before hooking:\", isfunctionhooked(foo)) --\u003e false\r\n\r\nhookfunction(foo, function()\r\n    print(\"Hello, new world!\")\r\nend)\r\n\r\nprint(\"After hooking:\", isfunctionhooked(foo)) --\u003e true\r\n\r\nrestorefunction(foo)\r\nprint(\"After restoring:\", isfunctionhooked(foo)) --\u003e false\n```",
        },
      },

      "islclosure()": {
        "insertText": "islclosure(${1:func})",
        "documentation": {
          value: "```lua\nfunction islclosure(func: function): boolean\n```\n\nReturns a boolean indicating whether the function is a lua closure.\n\nParameters:\n- func: function - The `function` to evaluate.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nprint(islclosure(foo)) --\u003e true\r\nprint(islclosure(print)) --\u003e false\n```",
        },
      },

      "isnetworkowner()": {
        "insertText": "isnetworkowner(${1:instance})",
        "documentation": {
          value: "```lua\nfunction isnetworkowner(instance: Instance): boolean\n```\n\nReturns boolean indicating whether the `LocalPlayer` is the network owner of a given instance.\n\nParameters:\n- instance: Instance - The `Instance` that the user has provided.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\")\r\nprint(isnetworkowner(part))\n```",
        },
      },

      "isnewcclosure()": {
        "insertText": "isnewcclosure(${1:func})",
        "documentation": {
          value: "```lua\nfunction isnewcclosure(func: function): boolean\n```\n\nReturns a boolean indicating whether the function has been created using `newcclosure`.\n\nParameters:\n- func: function - The `function` to evaluate.\n\n### Example\n\n```lua\nlocal function foo() end\r\nprint(isnewcclosure(foo)) --\u003e false\r\n\r\nlocal bar = newcclosure(foo)\r\nprint(isnewcclosure(bar)) --\u003e true\n```",
        },
      },

      "isourthread()": {
        "insertText": "isourthread(${1:thread})",
        "documentation": {
          value: "```lua\nfunction isourthread(thread: thread): boolean\n```\n\nReturns a boolean indicating whether the thread is a Potassium thread.\n\nParameters:\n- thread: thread - The `thread` to evaluate.\n\n### Example\n\n```lua\nfor _, thread in getallthreads() do\r\n    if isourthread(thread) then\r\n        print(thread)\r\n    end\r\nend\n```",
        },
      },

      "isrbxactive()": {
        "insertText": "isrbxactive()",
        "documentation": {
          value: "```lua\nfunction isrbxactive(): boolean\n```\n\nReturns a boolean indicating whether roblox is currently in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nlocal isactive = isrbxactive()\r\nprint(\"isactive: \", isactive)\n```",
        },
      },

      "isreadonly()": {
        "insertText": "isreadonly(${1:table})",
        "documentation": {
          value: "```lua\nfunction isreadonly(table: table): boolean\n```\n\nChecks if the `table` is read-only/protected.\n\nAlias: ``is_readonly``\n\nParameters:\n- table: table - The table to check the read-only status of.\n\n### Example\n\n```lua\nlocal protected = table.freeze({ foo = \"bar\" })\r\n\r\nprint(isreadonly(protected)) --\u003e true\n```",
        },
      },

      "isrenderobj()": {
        "insertText": "isrenderobj(${1:object})",
        "documentation": {
          value: "```lua\nfunction isrenderobj(object: DrawingObject): boolean\n```\n\nReturns a boolean indicating whether the object is a `DrawingObject`.\n\nParameters:\n- object: DrawingObject - The `DrawingObject` to evaluate.\n\n### Example\n\n```lua\nlocal circle = Drawing.new(\"Circle\")\r\nlocal part = Instance.new(\"Part\")\r\n\r\nprint(isrenderobj(circle))\r\nprint(isrenderobj(part))\n```",
        },
      },

      "isscriptable()": {
        "insertText": "isscriptable(${1:instance}, ${2:property})",
        "documentation": {
          value: "```lua\nfunction isscriptable(instance: Instance, property: string): boolean\n```\n\nReturns boolean indicating whether a property is scriptable.\n\nParameters:\n- instance: Instance - The `Instance` that contains the property.\n- property: string - The name of the property returned.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\")\r\nprint(isscriptable(part, \"Transparency\")) --\u003e false\n```",
        },
      },

      "keypress()": {
        "insertText": "keypress(${1:keycode})",
        "documentation": {
          value: "```lua\nfunction keypress(keycode: number)\n```\n\nSimulate a key being pressed. The key press will only be simulated if Roblox\u0027s currently active or in focus.\n\nParameters:\n- keycode: number - The keycode to press. The only accepted keycodes are Window\u0027s Virtual-Key codes.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nlocal H_KEYCODE = 0x48\r\n\r\nkeypress(H_KEYCODE)\r\ntask.wait()\r\nkeyrelease(H_KEYCODE)\n```",
        },
      },

      "keyrelease()": {
        "insertText": "keyrelease(${1:keycode})",
        "documentation": {
          value: "```lua\nfunction keyrelease(keycode: number)\n```\n\nSimulate a key being released. The key release will only be simulated if Roblox\u0027s currently active or in focus.\n\nParameters:\n- keycode: number - The keycode to release. The only accepted keycodes are Window\u0027s Virtual-Key codes.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nlocal H_KEYCODE = 0x48\r\n\r\nkeypress(H_KEYCODE)\r\ntask.wait()\r\nkeyrelease(H_KEYCODE)\n```",
        },
      },

      "keytap()": {
        "insertText": "keytap(${1:keycode})",
        "documentation": {
          value: "```lua\nfunction keytap(keycode: number)\n```\n\nSimulate a key being pressed and released. The key tap will only be simulated if Roblox\u0027s currently active or in focus.\n\nAlias: ``keyclick``\n\nParameters:\n- keycode: number - The keycode to tap. The only accepted keycodes are Window\u0027s Virtual-Key codes.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nlocal H_KEYCODE = 0x48\r\nkeytap(H_KEYCODE)\n```",
        },
      },

      "listfiles()": {
        "insertText": "listfiles(${1:path})",
        "documentation": {
          value: "```lua\nfunction listfiles(path: string): {string}\n```\n\nReturns an array with the list of files in the specified directory.\n\nParameters:\n- path: string - The path you want to list files from.\n\n### Example\n\n```lua\nfor index, file in listfiles(\"\") do -- list files from workspace root\r\n  print(index, file)\r\nend\n```",
        },
      },

      "loadfile()": {
        "insertText": "loadfile(${1:file}, ${2:chunkname})",
        "documentation": {
          value: "```lua\nfunction loadfile(file: string, chunkname: string): (function?, string?)\n```\n\nLoadstring\u0027s the file specified and returning its chunk\n\nParameters:\n- file: string - The path to the file you\u0027re looking to load code from.\n- chunkname: string - The chunk string you want to have.\n\n### Example\n\n```lua\nlocal chunk, error = loadfile(\"test.txt\")\r\nif error then\r\n    print(\"Code failed to compile, error:\", error)\r\n    return\r\nend\r\n\r\nchunk()\n```",
        },
      },

      "loadstring()": {
        "insertText": "loadstring(${1:source}, ${2:chunkname})",
        "documentation": {
          value: "```lua\nfunction loadstring(source: string, chunkname: string?): function?, string?\n```\n\n\"Creates a chunk from the provided source code. The environment of the returned function is the global environment.\n\nParameters:\n- source: string - The `source` that will be used to create a chunk.\n- chunkname: string - `chunkname` will be used as the chunk name for error messages and debug information.\n\n### Example\n\n```lua\nlocal source = \"print(\u0027Hello, world!\u0027)\"\r\nlocal chunk = loadstring(source, \"hello\")\r\nchunk() --\u003e Hello, world!\r\n\r\nsource = \"error(\u0027Goodbye, world!\u0027)\"\r\nchunk = loadstring(source, \"goodbye\")\r\nchunk() --\u003e Error: Goodbye, world!\n```",
        },
      },

      "makefolder()": {
        "insertText": "makefolder(${1:path})",
        "documentation": {
          value: "```lua\nfunction makefolder(path: string): ()\n```\n\nCreates a folder in the specified \u0027path\u0027.\n\nParameters:\n- path: string - The path you want to create a folder with\n\n### Example\n\n```lua\nprint(makefolder(\"mk\"))\n```",
        },
      },

      "makereadonly()": {
        "insertText": "makereadonly(${1:table})",
        "documentation": {
          value: "```lua\nfunction makereadonly(table: table): ()\n```\n\nSets the `table` to read-only.\n\nParameters:\n- table: table - The table to set as read-only.\n\n### Example\n\n```lua\nlocal protected = { foo = \"bar\" }\r\n\r\nmakereadonly(protected) -- Equivalent to setreadonly(protected, true) or table.freeze(protected)\r\n\r\nprotected.foo = \"test\" --\u003e attempt to modify a readonly table\n```",
        },
      },

      "makewritable()": {
        "insertText": "makewritable(${1:table})",
        "documentation": {
          value: "```lua\nfunction makewritable(table: table): ()\n```\n\nMakes the `table` writable.\n\nParameters:\n- table: table - The read-only table to make writable.\n\n### Example\n\n```lua\nlocal protected = table.freeze({ foo = \"bar\" })\r\n\r\nprint(pcall(function() protected.bar = \"foo\" end)) --\u003e false, attempt to modify a readonly table\r\n\r\nmakewritable(protected) -- Equivalent to setreadonly(protected, false)\r\n\r\nprotected.bar = \"foo\"\r\nprint(protected.bar, table.isfrozen(protected)) --\u003e foo, false\r\n\r\nmakereadonly(protected) -- Equivalent to setreadonly(protected, true) or table.freeze(protected)\n```",
        },
      },

      "messagebox()": {
        "insertText": "messagebox(${1:text}, ${2:caption}, ${3:flags})",
        "documentation": {
          value: "```lua\nfunction messagebox(text: string, caption: string, flags: number): number\n```\n\nCreates a message box with the specified `text`, `caption` and `flags`.\n\nAlias: ``messageboxasync``\n\nParameters:\n- text: string - The message content to display inside the message box.\n- caption: string - The title text shown in the message box title bar.\n- flags: number - A bitmask of `uType` flags from `winuser.h` that control the buttons and icon displayed.\n\n### Example\n\n```lua\nlocal MB_ICONWARNING = 0x00000030\nlocal MB_CANCELTRYCONTINUE = 0x00000006\nlocal MB_DEFBUTTON2 = 0x00000100\n\nlocal IDCANCEL = 0x00000002\nlocal IDTRYAGAIN = 0x0000000A\nlocal IDCONTINUE = 0x0000000B\n\nlocal input = messagebox(\n\t\"?\",\n\t\"Resource not found\",\n\tbit32.bor(MB_ICONWARNING, MB_CANCELTRYCONTINUE, MB_DEFBUTTON2)\n)\n\nif input == IDCANCEL then\n    print(\"IDCANCEL\")\nelseif input == IDTRYAGAIN then\n    print(\"IDTRYAGAIN\")\nelseif input == IDCONTINUE then\n    print(\"IDCONTINUE\")\nend\n```",
        },
      },

      "mouse1click()": {
        "insertText": "mouse1click()",
        "documentation": {
          value: "```lua\nfunction mouse1click()\n```\n\nSimulate a left mouse click. The click will only be simulated if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse1click()\n```",
        },
      },

      "mouse1press()": {
        "insertText": "mouse1press()",
        "documentation": {
          value: "```lua\nfunction mouse1press()\n```\n\nSimulate a left mouse press. The left mouse press will only be simulated if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse1press()\r\ntask.wait()\r\nmouse1release()\n```",
        },
      },

      "mouse1release()": {
        "insertText": "mouse1release()",
        "documentation": {
          value: "```lua\nfunction mouse1release()\n```\n\nSimulate a left mouse release. The left mouse will only be released (simulated) if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse1press()\r\ntask.wait()\r\nmouse1release()\n```",
        },
      },

      "mouse2click()": {
        "insertText": "mouse2click()",
        "documentation": {
          value: "```lua\nfunction mouse2click()\n```\n\nSimulate a right mouse click. The click will only be simulated if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse2click()\n```",
        },
      },

      "mouse2press()": {
        "insertText": "mouse2press()",
        "documentation": {
          value: "```lua\nfunction mouse2press()\n```\n\nSimulate a right mouse press. The right mouse press will only be simulated if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse2press()\r\ntask.wait()\r\nmouse2release()\n```",
        },
      },

      "mouse2release()": {
        "insertText": "mouse2release()",
        "documentation": {
          value: "```lua\nfunction mouse2release()\n```\n\nSimulate a right mouse release. The right mouse will only be released (simulated) if Roblox\u0027s currently active or in focus.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmouse2press()\r\ntask.wait()\r\nmouse2release()\n```",
        },
      },

      "mousemoveabs()": {
        "insertText": "mousemoveabs(${1:x}, ${2:y})",
        "documentation": {
          value: "```lua\nfunction mousemoveabs(x: number, y: number)\n```\n\nSimulate a mouse movement. This movement is not relative to the current mouse\u0027s position. The mouse will only be moved if Roblox\u0027s currently active or in focus.\n\nParameters:\n- x: number - The absolute X coordinate to move the mouse to.\n- y: number - The absolute Y coordinate to move the mouse to.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmousemoveabs(100, 100)\n```",
        },
      },

      "mousemoverel()": {
        "insertText": "mousemoverel(${1:x}, ${2:y})",
        "documentation": {
          value: "```lua\nfunction mousemoverel(x: number, y: number)\n```\n\nSimulate a mouse movement. This movement is relative to the current mouse\u0027s position. The mouse will only be moved if Roblox\u0027s currently active or in focus.\n\nParameters:\n- x: number - The relative X coordinate to move the mouse to.\n- y: number - The relative Y coordinate to move the mouse to.\n\n### Example\n\n```lua\ntask.wait(1) -- Give the user time to put roblox in focus.\r\n\r\nmousemoverel(100, 100)\n```",
        },
      },

      "mousescroll()": {
        "insertText": "mousescroll(${1:scroll})",
        "documentation": {
          value: "```lua\nfunction mousescroll(scroll: number)\n```\n\nSimulate a mouse scroll. The mouse will only scroll if Roblox\u0027s currently active or in focus.\n\nParameters:\n- scroll: number - The relative scroll amount. See the example below.\n\n### Example\n\n```lua\nmousescroll(10) --\u003e Scrolls up\r\n\r\ntask.wait()\r\n\r\nmousescroll(-10) --\u003e Scrolls down\n```",
        },
      },

      "newcclosure()": {
        "insertText": "newcclosure(${1:func}, ${2:name})",
        "documentation": {
          value: "```lua\nfunction newcclosure(func: function, name: string?): function\n```\n\nCreates a new C closure for \u0027func\u0027.\n\nParameters:\n- func: function - Creates a C function that wraps around \u0027func\u0027\n- name: string - Set a name for the newly created C closure.\n\n### Example\n\n```lua\nlocal function foo()\r\n    print(\"Hello, world!\")\r\nend\r\n\r\nlocal newCClosure = newcclosure(foo, \"bar\")\r\n\r\nnewCClosure() --\u003e Hello, world!\r\nprint(debug.info(newCClosure, \"n\")) --\u003e bar\n```",
        },
      },

      "newlclosure()": {
        "insertText": "newlclosure(${1:func}, ${2:name})",
        "documentation": {
          value: "```lua\nfunction newlclosure(func: function, name: string?): function\n```\n\nCreates a new Lua closure for \u0027func\u0027.\n\nParameters:\n- func: function - Creates a Lua function that wraps around \u0027func\u0027\n- name: string - Set a name for the newly created L closure.\n\n### Example\n\n```lua\nprint(islclosure(warn)) --\u003e false\r\n\nlocal luaClosure = newlclosure(warn)\nprint(islclosure(luaClosure)) --\u003e true\n```",
        },
      },

      "oth.get_original_thread()": {
        "insertText": "oth.get_original_thread()",
        "documentation": {
          value: "```lua\nfunction oth.get_original_thread(): thread\n```\n\nReturn the original thread this hook comes from, or nil if the current thread is not a hook.\n\n### Example\n\n```lua\noth.hook(game.GetService, function(...)\r\n    local thread = oth.get_original_thread()\r\n    local script = getscriptfromthread(thread)\r\n\r\n    if script and script.Parent == nil then\r\n        return task.wait(9e9)\r\n    end\r\n\r\n    return oth.get_root_callback()(...)\r\nend)\n```",
        },
      },

      "oth.get_root_callback()": {
        "insertText": "oth.get_root_callback()",
        "documentation": {
          value: "```lua\nfunction oth.get_root_callback(): function\n```\n\nRetrieves a function that can be used to call the original function in the context of a hook thread.\n\n### Example\n\n```lua\noth.hook(game.FindService, function(self, service)\r\n    if service == \"VirtualInputManager\" then\r\n        return nil\r\n    end\r\n\r\n    return oth.get_root_callback()(self, service)\r\nend)\n```",
        },
      },

      "oth.hook()": {
        "insertText": "oth.hook(${1:target}, ${2:hook})",
        "documentation": {
          value: "```lua\nfunction oth.hook(target: function, hook: function): ()\n```\n\nHooks a function by utilizing a secure \u0027Off-Thread\u0027 execution model that runs hook code on isolated threads. This method is specifically designed for hooking C functions where standard `hookfunction` might be detected.\n\nParameters:\n- target: function - The function to hook.\n- hook: function - The hook function.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(Instance.new, function(...)\r\n    print(\"Creating new instance:\", ...)\r\n\r\n    return old(...)\r\nend)\n```",
        },
      },

      "oth.is_hook_thread()": {
        "insertText": "oth.is_hook_thread()",
        "documentation": {
          value: "```lua\nfunction oth.is_hook_thread(): boolean\n```\n\nReturns whether or not this thread is a hook thread.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(math.random, function(...)\r\n    if oth.is_hook_thread() then\r\n        return 1\r\n    end\r\n    \r\n    return old(...)\r\nend)\n```",
        },
      },

      "oth.unhook()": {
        "insertText": "oth.unhook(${1:target})",
        "documentation": {
          value: "```lua\nfunction oth.unhook(target: function): ()\n```\n\nUnhooks a function previously hooked with `oth.hook`.\n\nParameters:\n- target: function - The function to unhook.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = oth.hook(print, function(...)\r\n    return warn(...)\r\nend)\r\n\r\nprint(\"This will be a warning.\")\r\n\r\noth.unhook(print)\r\n\r\nprint(\"This will be a print.\")\n```",
        },
      },

      "PsmSignal.new()": {
        "insertText": "PsmSignal.new()",
        "documentation": {
          value: "```lua\nfunction PsmSignal.new(): PsmSignal\n```\n\nConstructs a new `PsmSignal` object.\n\nAlias: ``Signal.new``\n\n### Example\n\n```lua\nlocal signal = PsmSignal.new()\r\n\r\nsignal:Once(function()\r\n    print(\"Signal fired!\")\r\nend)\r\n\r\nsignal:Fire()\n```",
        },
      },

      "queueonteleport()": {
        "insertText": "queueonteleport(${1:code})",
        "documentation": {
          value: "```lua\nfunction queueonteleport(code: string): ()\n```\n\nQueues \u0027code\u0027 for teleport and executes once a teleport completes.\n\nAlias: ``queue_on_teleport``\n\nParameters:\n- code: string - The Lua code string to execute once a teleport completes.\n\n### Example\n\n```lua\nqueueonteleport([[\r\nprint(\"Hello, world!\")\r\n]])\n```",
        },
      },

      "raknet.add_send_hook()": {
        "insertText": "raknet.add_send_hook($0)",
        "documentation": {
          value: "```lua\nfunction raknet.add_send_hook(callback: (packet: RakNetPacket) -\u003e nil): ()\n```\n\nRegisters a callback that runs before a `RakNetPacket` is sent.\n\nParameters:\n- callback: function - The callback function to register.\n\n### Example\n\n```lua\nraknet.add_send_hook(function(packet)\r\n    print(\"ID:\", packet.PacketId)\r\n    print(\"Size:\", packet.Size)\r\n    print(\"Priority:\", packet.Priority)\r\n    print(\"Data (as buffer):\", packet.AsBuffer)\r\n    print(\"Data (as array):\", packet.AsArray)\r\n    print(\"Data (as string):\", packet.AsString)\r\n    print(\"Reliability:\", packet.Reliability)\r\n    print(\"Ordering Channel:\", packet.OrderingChannel)\r\nend)\n```",
        },
      },

      "raknet.remove_send_hook()": {
        "insertText": "raknet.remove_send_hook(${1:callback})",
        "documentation": {
          value: "```lua\nfunction raknet.remove_send_hook(callback: function): ()\n```\n\nRemoves a previously registered send hook.\n\nParameters:\n- callback: function - The callback function to remove.\n\n### Example\n\n```lua\nlocal send_hook = nil\r\nsend_hook = function(packet)\r\n    print(\"ID:\", packet.PacketId)\r\n    print(\"Size:\", packet.Size)\r\n    print(\"Priority:\", packet.Priority)\r\n    print(\"Data (as buffer):\", packet.AsBuffer)\r\n    print(\"Data (as array):\", packet.AsArray)\r\n    print(\"Data (as string):\", packet.AsString)\r\n    print(\"Reliability:\", packet.Reliability)\r\n    print(\"Ordering Channel:\", packet.OrderingChannel)\r\n\r\n    raknet.remove_send_hook(send_hook)\r\nend\r\n\r\nraknet.add_send_hook(send_hook)\n```",
        },
      },

      "raknet.send()": {
        "insertText": "raknet.send(${1:packet}, ${2:priority}, ${3:reliability}, ${4:orderingChannel})",
        "documentation": {
          value: "```lua\nfunction raknet.send(packet: buffer | table | string, priority: int, reliability: int, orderingChannel: int): ()\n```\n\nSends a packet with a payload, priority, reliability, and ordering channel.\n\nParameters:\n- packet: buffer | table | string - The packet to send.\n- priority: int - The priority of the packet.\n- reliability: int - The reliability mode of the packet.\n- orderingChannel: int - The ordering channel of the packet used for ordered traffic.\n\n### Example\n\n```lua\nlocal buf = buffer.create(2);\r\nbuffer.writeu8(buf, 1, 123);\r\n\r\nraknet.send(buf, 1, 0, 0)\n```",
        },
      },

      "rconsoleclear()": {
        "insertText": "rconsoleclear()",
        "documentation": {
          value: "```lua\nfunction rconsoleclear()\n```\n\nClears all text in the console.\n\n### Example\n\n```lua\nrconsolecreate()\r\nrconsoleprint(\"Goodbye, world!\\n\")\r\ntask.wait(1)\r\nrconsolewarn(\"Clearing console...\")\r\ntask.wait(1)\r\nrconsoleclear()\n```",
        },
      },

      "rconsolecreate()": {
        "insertText": "rconsolecreate()",
        "documentation": {
          value: "```lua\nfunction rconsolecreate()\n```\n\nCreates a console window. Text previously output to the console will not be cleared. Only 1 console can be created.\n\n### Example\n\n```lua\nrconsolecreate()\r\nrconsoleprint(\"Hello, world!\\n\")\n```",
        },
      },

      "rconsoledestroy()": {
        "insertText": "rconsoledestroy()",
        "documentation": {
          value: "```lua\nfunction rconsoledestroy()\n```\n\nDestroys the console window. Text output to the console will be cleared.\n\n### Example\n\n```lua\nrconsolecreate()\r\nrconsoleprint(\"Hello, world!\\n\")\r\n\r\nrconsoledestroy() -- Destroy console and clear old messages.\r\n\r\nrconsolecreate()\r\nrconsoleprint(\"Hello, world! Again!\\n\")\n```",
        },
      },

      "rconsoleerror()": {
        "insertText": "rconsoleerror(${1:text})",
        "documentation": {
          value: "```lua\nfunction rconsoleerror(text: string): ()\n```\n\nPrints a red message to the console. If the console hasn\u0027t been already created, `rconsoleerror` will create one.\n\nParameters:\n- text: string - The text to be printed. Does not clear existing text or create a new line.\n\n### Example\n\n```lua\nrconsoleerror(\"ERROR!\\n\")\n```",
        },
      },

      "rconsoleinfo()": {
        "insertText": "rconsoleinfo(${1:text})",
        "documentation": {
          value: "```lua\nfunction rconsoleinfo(text: string): ()\n```\n\nPrints a dark blue message to the console. If the console hasn\u0027t been already created, `rconsoleinfo` will create one.\n\nParameters:\n- text: string - The text to be printed. Does not clear existing text or create a new line.\n\n### Example\n\n```lua\nrconsoleinfo(\"INFO!\\n\")\n```",
        },
      },

      "rconsoleinput()": {
        "insertText": "rconsoleinput()",
        "documentation": {
          value: "```lua\nfunction rconsoleinput(): string\n```\n\nReceives input directly from the console. Any thread that runs this function will be suspended until input is received.\n\n### Example\n\n```lua\nrconsolecreate()\r\nrconsoleprint(\"What\u0027s your name?\\n\")\r\nlocal username = rconsoleinput()\r\nprint(username)\n```",
        },
      },

      "rconsoleprint()": {
        "insertText": "rconsoleprint(${1:text})",
        "documentation": {
          value: "```lua\nfunction rconsoleprint(text: string): ()\n```\n\nPrints to the console. If the console hasn\u0027t been already created, `rconsoleprint` will create one.\n\nParameters:\n- text: string - The text to be printed. Does not clear existing text or create a new line.\n\n### Example\n\n```lua\nrconsoleprint(\"Hello, world!\\n\")\n```",
        },
      },

      "rconsolesettitle()": {
        "insertText": "rconsolesettitle(${1:title})",
        "documentation": {
          value: "```lua\nfunction rconsolesettitle(title: string): ()\n```\n\nSets the title of the console window.\n\nAlias: ``rconsolename``\n\nParameters:\n- title: string - The string that the title will be set to.\n\n### Example\n\n```lua\nrconsolecreate()\r\nrconsolesettitle(\"Custom Title\")\n```",
        },
      },

      "rconsolewarn()": {
        "insertText": "rconsolewarn(${1:text})",
        "documentation": {
          value: "```lua\nfunction rconsolewarn(text: string): ()\n```\n\nPrints a yellow message to the console. If the console hasn\u0027t been already created, `rconsolewarn` will create one.\n\nParameters:\n- text: string - The text to be printed. Does not clear existing text or create a new line.\n\n### Example\n\n```lua\nrconsolewarn(\"WARNING!\\n\")\n```",
        },
      },

      "readfile()": {
        "insertText": "readfile(${1:file})",
        "documentation": {
          value: "```lua\nfunction readfile(file: string): string\n```\n\nRead an existing file from the \u0027workspace\u0027 directory.\n\nParameters:\n- file: string - The path to the file you\u0027re looking to read.\n\n### Example\n\n```lua\nprint(\"Contents of \u0027test.txt\u0027\", readfile(\"test.txt\"))\n```",
        },
      },

      "Regex.Escape()": {
        "insertText": "Regex.Escape(${1:contents})",
        "documentation": {
          value: "```lua\nfunction Regex.Escape(contents: string): string\n```\n\nEscapes a string for use in a regular expression.\n\nParameters:\n- contents: string - The string to escape.\n\n### Example\n\n```lua\nlocal input = \"[DEBUG] (ID): 99821\"\r\nlocal label = \"[DEBUG] (ID): \"\r\n\r\nlocal escaped = Regex.Escape(label)\r\nlocal regex = Regex.new(escaped .. \"(\\\\d+)\")\r\nlocal match = regex:Match(input)\r\n\r\nif match then\r\n    print(\"ID:\", regex:Replace(match, \"$1\"))\r\nend\n```",
        },
      },

      "Regex.new()": {
        "insertText": "Regex.new(${1:pattern})",
        "documentation": {
          value: "```lua\nfunction Regex.new(pattern: string): Regex\n```\n\nConstructs a new `Regex` object using the specified pattern.\n\nParameters:\n- pattern: string - The regular expression pattern.\n\n### Example\n\n```lua\nlocal input = \"My Cool Id: 31235335\"\r\nlocal regex = Regex.new(\"My Cool Id:\\\\s*(\\\\w+)\")\r\nlocal match = regex:Match(input)\r\n\r\nif match then\r\n    print(\"ID:\", regex:Replace(match, \"$1\"))\r\nend\n```",
        },
      },

      "replicatesignal()": {
        "insertText": "replicatesignal(${1:signal}, ${2:...: any?})",
        "documentation": {
          value: "```lua\nfunction replicatesignal(signal: RBXScriptSignal, ...: any?)\n```\n\nFires all server connections connected to a `RBXScriptSignal`. Arguments provided must be valid, otherwise it will fail.\n\nParameters:\n- signal: RBXScriptSignal - The specific signal to replicate.\n\n### Example\n\n```lua\nlocal clickDetector = Instance.new(\"ClickDetector\")\r\nlocal player = game.Players.LocalPlayer\r\n\r\nreplicatesignal(clickDetector.MouseActionReplicated, player, 0)\n```",
        },
      },

      "request()": {
        "insertText": "request(${1:options})",
        "documentation": {
          value: "```lua\nfunction request(options: HttpRequest): ()\n```\n\nCreates a HTTP request with specified options.\n\nParameters:\n- options: HttpRequest - The options for the HTTP request.\n\n### Example\n\n```lua\nlocal response = request({\n\tUrl = \"https://httpbin.org\", Method = \"GET\"\n})\n\nprint(response.Success)\nprint(response.StatusCode)\nprint(response.StatusMessage)\n```",
        },
      },

      "restorefunction()": {
        "insertText": "restorefunction(${1:target})",
        "documentation": {
          value: "```lua\nfunction restorefunction(target: function): function\n```\n\nRestores a previously hooked Lua or C function to its original implementation.\n\nParameters:\n- target: function - The `function` to restore.\n\n### Example\n\n```lua\nlocal old = nil\r\nold = hookfunction(tick, function(...)\r\n    local result = old(...)\r\n\r\n    print(\"Tick:\", result)\r\n    restorefunction(tick)\r\n\r\n    return result\r\nend)\n```",
        },
      },

      "run_on_actor()": {
        "insertText": "run_on_actor(${1:actor}, ${2:script}, ${3:...})",
        "documentation": {
          value: "```lua\nfunction run_on_actor(actor: Actor, script: string, ...): ()\n```\n\nExecutes a script on an actor.\n\nParameters:\n- actor: Actor - The `actor` used in script execution.\n- script: string - The script to be executed on `actor`.\n\n### Example\n\n```lua\nrun_on_actor(getactors()[1], [[\r\n    print(\"Hello, world!\")\r\n]])\n```",
        },
      },

      "run_on_thread()": {
        "insertText": "run_on_thread(${1:thread}, ${2:script}, ${3:...})",
        "documentation": {
          value: "```lua\nfunction run_on_thread(thread: thread, script: string, ...): ()\n```\n\nExecutes a script on an actor thread.\n\n### Example\n\n```lua\nrun_on_thread(getactorthreads()[1], [[\n    print(\"Hello, world!\")\n]])\n```",
        },
      },

      "saveinstance()": {
        "insertText": "saveinstance(${1:object}, ${2:options})",
        "documentation": {
          value: "```lua\nfunction saveinstance(object: Instance, options: table?): ()\n```\n\nSaves an instance in .rbxl or .rbxm format.\n\nParameters:\n- object: Instance - The `Instance` to save. Typically `game` to save the entire DataModel.\n- options: table - A table of options controlling decompilation, threading, filtering, and output behaviour. See the Options table below.\n\n### Example\n\n```lua\nsaveinstance(game, {\r\n    FileName = \"game.rbxl\",\r\n    Decompile = true,\r\n    MaxThreads = 5 -- Adjust depending on PC specs\r\n})\n```",
        },
      },

      "setclipboard()": {
        "insertText": "setclipboard(${1:text})",
        "documentation": {
          value: "```lua\nfunction setclipboard(text: string): ()\n```\n\nSets the \u0027text\u0027 into the user clipboard.\n\nAlias: ``toclipboard``\n\nParameters:\n- text: string - The text to copy into the user\u0027s system clipboard.\n\n### Example\n\n```lua\nsetclipboard(\"Hello, world!\")\n```",
        },
      },

      "setfflag()": {
        "insertText": "setfflag(${1:fflag}, ${2:value})",
        "documentation": {
          value: "```lua\nfunction setfflag(fflag: string, value: any): ()\n```\n\nSets the value of a Fast Flag.\n\nAlias: ``setfastflag``\n\n### Example\n\n```lua\n-- This will cap the users fps to 120 without setfpscap.\nsetfflag(\"TaskSchedulerTargetFps\", 120)\n```",
        },
      },

      "setfpscap()": {
        "insertText": "setfpscap(${1:cap})",
        "documentation": {
          value: "```lua\nfunction setfpscap(cap: number): ()\n```\n\nSets the fps cap set by the client.\n\nParameters:\n- cap: number - The frame rate limit to apply. Use a very large value (e.g. `2000`) to effectively uncap the frame rate.\n\n### Example\n\n```lua\nprint(setfpscap(2000))\n```",
        },
      },

      "sethiddenproperty()": {
        "insertText": "sethiddenproperty(${1:instance}, ${2:property}, ${3:value})",
        "documentation": {
          value: "```lua\nfunction sethiddenproperty(instance: Instance, property: string, value: any): boolean\n```\n\nSets the value of a hidden property. Returns a boolean indicating whether the property is hidden.\n\nAlias: ``sethiddenprop``\n\nParameters:\n- instance: Instance - The `Instance` that contains the hidden property.\n- property: string - The name of the property.\n- value: any - The new value of the property.\n\n### Example\n\n```lua\nlocal fire = Instance.new(\"Fire\")\r\nlocal hidden = sethiddenproperty(fire, \"size_xml\", 123)\r\nprint(hidden) --\u003e true\n```",
        },
      },

      "setnamecallmethod()": {
        "insertText": "setnamecallmethod(${1:method})",
        "documentation": {
          value: "```lua\nfunction setnamecallmethod(method: string): ()\n```\n\nSets the current threads\u0027s `__namecall` method.\n\nAlias: ``set_namecall_method``\n\nParameters:\n- method: string - The new namecall method name to set on the current state.\n\n### Example\n\n```lua\ngame:GetFullName()\r\nprint(getnamecallmethod()) --\u003e GetFullName\r\n\r\nsetnamecallmethod(\"getFullName\")\r\nprint(getnamecallmethod()) --\u003e getFullName\r\n\r\nprint(getrawmetatable(game).__namecall(game)) --\u003e Ugc\n```",
        },
      },

      "setproximitypromptduration()": {
        "insertText": "setproximitypromptduration(${1:proximityprompt}, ${2:duration})",
        "documentation": {
          value: "```lua\nfunction setproximitypromptduration(proximityprompt: ProximityPrompt, duration: number): ()\n```\n\nSets the value of a proximity prompt\u0027s duration.\n\nParameters:\n- proximityprompt: ProximityPrompt - The `ProximityPrompt` that contains the duration.\n- duration: number - The new duration of the `ProximityPrompt`.\n\n### Example\n\n```lua\nlocal proximityprompt = Instance.new(\"ProximityPrompt\")\r\nsetproximitypromptduration(proximityprompt, 99)\r\n\r\nlocal duration = getproximitypromptduration(proximityprompt)\r\nprint(duration) --\u003e 99\n```",
        },
      },

      "setrawmetatable()": {
        "insertText": "setrawmetatable(${1:tbl}, ${2:meta})",
        "documentation": {
          value: "```lua\nfunction setrawmetatable(tbl: table | userdata, meta: table): table?\n```\n\nSets the \u0027metatable\u0027 for a table or userdata whilst ignoring the \u0027__metatable\u0027 value.\n\nAlias: ``debug.setmetatable``\n\nParameters:\n- tbl: table | userdata - A table or userdata.\n- meta: table - The metatable you want to set the \u0027tbl\u0027 to.\n\n### Example\n\n```lua\nlocal t = setmetatable({}, {\r\n  __index = function(self, index)\r\n      print(index)\r\n  end,\r\n  __metatable = \"This table is locked.\"\r\n})\r\n\r\nprint(pcall(setmetatable, t, {})) --\u003e false, cannot change a protected metatable\r\nprint(setrawmetatable(t, {})) --\u003e table: 0x......\n```",
        },
      },

      "setrbxclipboard()": {
        "insertText": "setrbxclipboard(${1:text})",
        "documentation": {
          value: "```lua\nfunction setrbxclipboard(text: string): ()\n```\n\nSets the \u0027text\u0027 into the Roblox Studio clipboard.\n\nParameters:\n- text: string - The XML or binary model data to copy into the Roblox Studio clipboard.\n\n### Example\n\n```lua\nlocal part = Instance.new(\"Part\")\r\npart.Name = \"Exploit Side\"\r\n\r\nsaveinstance(part, \"clipboard.rbxmx\")\r\ntask.wait(2)\r\nsetrbxclipboard(readfile(\"clipboard.rbxmx\"))\r\ndefile(\"clipboard.rbxmx\")\n```",
        },
      },

      "setreadonly()": {
        "insertText": "setreadonly(${1:table}, ${2:readonly})",
        "documentation": {
          value: "```lua\nfunction setreadonly(table: table, readonly: boolean): ()\n```\n\nSets the \u0027table\u0027s read-only/protected status.\n\nAlias: ``set_readonly``\n\nParameters:\n- table: table - The table whose read-only status will be changed.\n- readonly: boolean - Whether to make the table read-only (`true`) or writable (`false`).\n\n### Example\n\n```lua\nlocal protected = table.freeze({ foo = \"bar\" })\r\n\r\nprint(pcall(function() protected.bar = \"foo\" end)) --\u003e false, attempt to modify a readonly table\r\n\r\nsetreadonly(protected, false) -- Makes the table writable; similar to makewritable(protected)\r\n\r\nprotected.bar = \"foo\"\r\nprint(protected.bar, table.isfrozen(protected)) --\u003e foo, false\r\n\r\ntable.freeze(protected) -- Sets the table back to read-only; similar to makereadonly(protected)\n```",
        },
      },

      "setrenderproperty()": {
        "insertText": "setrenderproperty(${1:drawing}, ${2:property}, ${3:value})",
        "documentation": {
          value: "```lua\nfunction setrenderproperty(drawing: DrawingObject, property: string, value: any): ()\n```\n\nSets a property value on a `DrawingObject`.\n\nParameters:\n- drawing: DrawingObject - The drawing object to edit the property on.\n- property: string - The property to edit.\n- value: any - The value to set.\n\n### Example\n\n```lua\nlocal circle = Drawing.new(\"Circle\")\r\n\r\nsetrenderproperty(circle, \"Radius\", 50)\r\nsetrenderproperty(circle, \"Position\", Vector2.new(300, 300))\r\nsetrenderproperty(circle, \"NumSides\", 32)\r\nsetrenderproperty(circle, \"Color\", Color3.fromRGB(255, 0, 0))\r\nsetrenderproperty(circle, \"Transparency\", 1)\r\nsetrenderproperty(circle, \"Visible\", true)\r\nsetrenderproperty(circle, \"Filled\", true)\r\nsetrenderproperty(circle, \"Thickness\", 2)\r\nsetrenderproperty(circle, \"ZIndex\", 1)\r\n\r\ntask.wait(1)\r\ncircle:Destroy()\n```",
        },
      },

      "setscriptable()": {
        "insertText": "setscriptable(${1:instance}, ${2:property}, ${3:scriptable})",
        "documentation": {
          value: "```lua\nfunction setscriptable(instance: Instance, property: string, scriptable: boolean): ()\n```\n\nSets whether a property is scriptable.\n\nParameters:\n- instance: Instance - The `Instance` that contains the property.\n- property: string - The name of the property.\n- scriptable: boolean - Whether the property will become scriptable.\n\n### Example\n\n```lua\nlocal fire = Instance.new(\"Fire\")\r\nsetscriptable(fire, \"size_xml\", true)\r\n\r\nfire.size_xml = 123\r\nprint(fire.size_xml) --\u003e 123\n```",
        },
      },

      "setsimulationradius()": {
        "insertText": "setsimulationradius(${1:simulationradius})",
        "documentation": {
          value: "```lua\nfunction setsimulationradius(simulationradius: number): ()\n```\n\nSets the simulation radius of the `LocalPlayer`.\n\nParameters:\n- simulationradius: number - The `LocalPlayer`\u0027s new simulation radius.\n\n### Example\n\n```lua\nsetsimulationradius(999)\r\nprint(getsimulationradius()) --\u003e 999\n```",
        },
      },

      "setstackhidden()": {
        "insertText": "setstackhidden(${1:func}, ${2:hidden})",
        "documentation": {
          value: "```lua\nfunction setstackhidden(func: function | number, hidden: boolean): ()\n```\n\nHide a function from call-stack based detections.\n\nParameters:\n- func: function | number - The function or level that will be hidden.\n- hidden: boolean - Determines whether the function should be hidden or unhidden.\n\n### Example\n\n```lua\nlocal function foo()\r\n\tprint(debug.traceback())\r\nend\r\n\r\nlocal function bar()\r\n\tfoo()\r\nend\r\n\r\nbar() -- expected output\r\n\r\nsetstackhidden(bar, true)\r\n\r\nbar() -- now hidden\n```",
        },
      },

      "setthreadidentity()": {
        "insertText": "getthreadidentity(${1:identity})",
        "documentation": {
          value: "```lua\nfunction getthreadidentity(identity: number): ()\n```\n\nSets the current thread\u0027s identity.\n\nParameters:\n- identity: number - The new identity of the current thread.\n\n### Example\n\n```lua\nsetthreadidentity(2)\r\nprint(getthreadidentity()) --\u003e 2\n```",
        },
      },

      "WebSocket.connect()": {
        "insertText": "WebSocket.connect(${1:url})",
        "documentation": {
          value: "```lua\nfunction WebSocket.connect(url: string): WebSocket\n```\n\nCreates a `WebSocket` connection using the specified URL.\n\nAlias: ``WebSocket.new``\n\nParameters:\n- url: string - The WebSocket URL that will be connected to.\n\n### Example\n\n```lua\nlocal ws = WebSocket.connect(\"wss://echo.websocket.org\")\r\nws:Send(\"Hello, WebSocket!\")\r\nws:Close()\n```",
        },
      },

      "writefile()": {
        "insertText": "writefile(${1:file}, ${2:contents})",
        "documentation": {
          value: "```lua\nfunction writefile(file: string, contents: string): ()\n```\n\nWrite a file to the \u0027workspace\u0027 directory.\n\nParameters:\n- file: string - The path to the file you\u0027re wanting to write to.\n- contents: string - The contents you want the file to contain.\n\n### Example\n\n```lua\nwritefile(\"test.txt\", tostring(workspace:GetServerTimeNow()))\n```",
        },
      },

    },
  };
});

