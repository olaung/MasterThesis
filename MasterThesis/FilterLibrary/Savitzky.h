#pragma once


using namespace System;
using namespace System::Collections::Generic;
#include <Eigen/Dense>

using namespace Eigen;

namespace Mgr
{
    public ref class SG
    {
    public:
        void Savitzky(List<double>^ D, int size, int frame);
    };
}
