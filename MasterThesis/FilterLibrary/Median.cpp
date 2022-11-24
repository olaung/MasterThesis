#include "pch.h"
#include "Median.h"

#include <algorithm>
#include <vector>

using namespace Mgr;

void MED::Median(List<double>^ D, int size, int frame)
{

	if (!((size < frame) || (size < 3)))
	{
		std::vector<double> window(frame);

		for (int i = frame / 2; i < size - frame/2; ++i)
		{

			for (int j = 0; j < frame; ++j)
			{
				window[j] = D[i - (frame / 2) + j];
			}

			std::sort(window.begin(), window.end());

			D[i - (frame / 2)] = (frame % 2 == 0) ? double((window[(frame / 2) - 1] + window[frame / 2]) / 2)
				: double(window[frame / 2]);

		}
	}
}

