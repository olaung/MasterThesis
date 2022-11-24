#pragma once

using namespace System;
using namespace System::Collections::Generic;
#include <Eigen/Dense>

namespace Mgr
{
	public ref class KF
	{
	public:
		void Kalman(List<double>^ D, int size, int frame);

	};
}