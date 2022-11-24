/*
Wzorowa³am siê na bibliotece Savitzky_Golay_Filter
https://github.com/ryan3971/Savitzky_Golay_Filter
*/

#include "pch.h"
#include "Savitzky.h"
#include <vector>
using namespace Mgr;

void SG::Savitzky(List<double>^ D, int size, int frame)
{
    int n = 3;

    MatrixXd A = MatrixXd(frame, n + 1);

    int start = floor(round(1 - frame) / 2);
    int end = floor((frame - 1) / 2);
    int i_start = abs(start);

    int i, j;
    for (i = start; i <= end; i++) {
        for (j = 0; j <= n; j++) {
            A(i + i_start, j) = pow(i, j);
        }
    }

    MatrixXd temp = (A.transpose() * A);
    MatrixXd coeff = temp.inverse() * A.transpose();

    static VectorXd coeff_row = coeff.row(0);

    std::vector<double> v(frame);

    for (int i = 0; i < frame; i++)
    {
        v[i] = coeff_row[i];
    }

    int sum, k;

    for (int i = frame/2; i <= (size - frame); i++)
    {
        k = 0;
        sum = 0;

        for (int j = i; j < i + frame; j++)
        {   
            sum += v[k] * D[j];
            k++;
        }
        D[i] = sum;
    }  
}

