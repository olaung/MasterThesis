#include "pch.h"
#include "MovingAverage.h"

using namespace Mgr;

void MA::MovingAverage(List<double>^ D, int size, int frame)
{
	double sum = 0;

	for (int i = 0; i <= (size - frame); i++)
	{
		sum = 0;

		for (int j = i; j < i + frame; j++)
		{
			sum += D[j];
		}

		D[i] = sum / frame;

	}
}