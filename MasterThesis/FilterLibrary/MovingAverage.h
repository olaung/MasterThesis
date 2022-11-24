#pragma once

using namespace System;
using namespace System::Collections::Generic;

namespace Mgr
{
	public ref class MA
	{
	public:
		void MovingAverage(List<double>^ D, int size, int frame);

	};
}