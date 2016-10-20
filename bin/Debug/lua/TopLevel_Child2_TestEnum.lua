require "utility";

TopLevel = {
	Child2 = {
		TestEnum = {

			One = 0,
			Two = 1,
			Three = 2,

		},
	},
};

return TopLevel.Child2.TestEnum.defineClass();