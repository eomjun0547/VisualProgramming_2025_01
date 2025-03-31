#include<iostream>
using namespace std;

int main()
{
	double weight, height;

	cout << "체중(kg) : ";
	cin >> weight;
	cout << "키(cm) : ";
	cin >> height;

	double bmi = weight / (height / 100) / (height / 100);
	cout << "BMI = " << bmi << endl;
}
