/*
Wzorowa³am siê na bibliotece kalman-cpp
https://github.com/hmartiro/kalman-cpp
*/

#include "pch.h"
#include "Kalman.h"
#include <vector>

using namespace Mgr;

void KF::Kalman(List<double>^ D, int size, int frame)
{
    int n = 3;
    int m = 1;
    

    double t = 0;
    std::vector<double> measurements;

    MatrixXd A(n, n), H(m, n), Q(n, n);
    MatrixXd R(m, m), P(n, n), I(n, n), K(n, n);
    VectorXd x_hat(n), x_hat_new(n), x0(n), y(m);
    
    double dt = 1.0 / 10;
    A << 1, dt, 0, 0, 1, dt, 0, 0, 1;
    H << 1, 0, 0;
    Q << .1, .1, .0, .1, .1, .0, .0, .0, .0;
    R << 5;
    P << .1, .1, .1, .1, 10, 10, .1, 10, 100;
    I.setIdentity();

    for each (int i in D) measurements.push_back(i);
    x0 << measurements[0], 0, -9.81;
    x_hat = x0;
    auto x_new = x_hat;

    for (int i = 0; i < measurements.size(); i++) 
    {
        t += dt;
        y << measurements[i];

        x_hat_new = A * x_hat;
        P = A * P * A.transpose() + Q;
        K = P * H.transpose() * (H * P * H.transpose() + R).inverse();
        x_hat_new += K * (y - H * x_hat_new);
        P = (I - K * H) * P;
        x_hat = x_hat_new;
        t += dt;
        
        D[i] = x_hat[0];
    }
}


