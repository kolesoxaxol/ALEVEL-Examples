// LibraryForStory.h
#include <iostream>
#pragma once

using namespace System;

namespace LibraryForStory {

	public ref class Sparrow
	{
		public:
			void Sparrow::Kill()
			{
				setlocale(LC_CTYPE, "rus");
				std::cout<< "Взял и клюнул Таракана, Вот и нету великана. И усов от него не осталося\n";
			}
				void Sparrow::Speak()
				{
					setlocale(LC_CTYPE, "rus");
					std::cout<< "Я воробей! Прилетел из dll C++ \n";
				}
	};
}

