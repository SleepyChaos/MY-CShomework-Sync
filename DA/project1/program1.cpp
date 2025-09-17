#include<stdio.h>
#include<time.h>
#include<stdlib.h>
#include<vector>
#include<iostream>
using namespace std;

long long NAX_SIZE = 10000;

vector<int> createRandNumb()
{
    int i;
    vector<int> data;
    srand(time(NULL));
    for(i=0;i<NAX_SIZE;i++)
    {
        data.push_back(rand()%100);
    }
    return data;
}


clock_t start, stop;
bool timeFlag = false;
double cpu_time_used;

void checkTime(){
    if(timeFlag) {
        stop = clock();
        timeFlag = false;
        cpu_time_used = ((double)(stop - start)) / CLOCKS_PER_SEC;
        //printf("Time used: %f\n",cpu_time_used);
    } else {
        start = clock();
        timeFlag = true;
    }
    }

double selectSort(vector<int> &data)
{
    checkTime();
    int len = NAX_SIZE;
    for(int i = 0; i < len-1; i++)
    {
        int minIndex = i;
        for(int j = i+1; j < len; j++){
            if(data[j] < data[minIndex]){
                minIndex = j;
            }
        }
        swap(data[i], data[minIndex]);
    }
    checkTime();
    return cpu_time_used;
}

double shellSort(vector<int> &data)
{
    checkTime();
    int len = NAX_SIZE;
    int h = 1;

    while(h < len/3) h = 3*h + 1;
    while(h >= 1)
    {
        for(int i = h; i < len; i++)
        {
            for(int j = i; j >= h && data[j] < data[j-h]; j -= h)
            {
                swap(data[j], data[j-h]);
            }
        }
        h /= 2;
    }
    checkTime();
    return cpu_time_used;
}

int main()
{
    long long Iterations_1 = 0;
    long long Iterations_2 = 0;

    cout << "请输入随机数组的长度: ";
    
    while(cin >> NAX_SIZE){
    cout << "请输入shell算法的测试次数: ";
    cin >> Iterations_1;
    cout << "请输入select算法的测试次数: ";
    cin >> Iterations_2;

    vector<int> data;
    data = createRandNumb();
    vector<int> temp_data;

    double sum = 0;
    temp_data = data;

    for(int i = 0; i < Iterations_1; i++){
        temp_data = data;
        sum += shellSort(temp_data);
    }
    printf("shellSort total : %lf\n", sum);
    printf("shellSort average time: %lf\n", sum/Iterations_1);

    double sum2 = 0;
    temp_data = data;
    
    for(int i = 0; i < Iterations_2; i++){
        temp_data = data;
        sum2 += selectSort(temp_data);
    }
    temp_data = data;
    printf("selectSort total : %lf\n", sum2);
    printf("selectSort time: %lf\n", sum2/Iterations_2);
    }
    return 0;
}