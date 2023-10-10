
#include "pch.h"
#include "CppUnitTest.h"
#include "../Tyuiu.GoogeRA.Sprint1.Task0.Lib/Tyuiu.GoogeRA.Sprint1.Task0.Lib.cpp"


		using namespace Microsoft::VisualStudio::CppUnitTestFramework;

	namespace TyuiuGoogeRASprint1Task0Test
	{
		TEST_CLASS(TyuiuGoogeRASprint1Task0Test)
		{
		public:

			TEST_METHOD(TestMethod1)
			{
				ISprint1Task0V01* diva1 = new Service1();
				int a = 10;
				int b = 10;
				int c = 10;
				int z;
				z = diva1->Rezalt(a, b, c);


			};
		};
	};

