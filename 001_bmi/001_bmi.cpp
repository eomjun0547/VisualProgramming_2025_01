#include<stdio.h>
int main()
{
	double h;
	double w;

	printf("키(cm) : ");
	scanf_s("%lf", &h);

	printf("체중(kg) : ");
	scanf_s("%lf", &w);

	h /= 100;

	double bmi = w / (h * h);
	printf("bmi = %lf\n", bmi);

}