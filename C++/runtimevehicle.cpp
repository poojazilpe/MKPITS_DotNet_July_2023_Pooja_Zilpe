#include<iostream>
using namespace std;
class Vehicle
{
	public:
		virtual void start()
		{
			cout<<"Start engine"<<endl;
		}
		virtual void stop()
		{
			cout<<"stop engine"<<endl;
		}
};
class Car:public Vehicle
{
	public:
		void start()
		{
			cout<<"Car is start"<<endl;
		}
		void stop()
		{
			cout<<"Car is stop"<<endl;
		}
};
class Motorcycle:public Vehicle
{
	public:
		void start()
		{
			cout<<"Motorcycle is start"<<endl;
		}
		void stop()
		{
			cout<<"Motorcycle is stop "<<endl;
		}
};
class Truck:public Vehicle
{
	public:
		void start()
		{
			cout<<"Truck is start"<<endl;
		}
		void stop()
		{
			cout<<"Truck is stop"<<endl;
		}
};
int main()
{
	Vehicle *v;
	Car c;
	Motorcycle m;
	Truck t;
	v=&c;
	v->start();
	v->stop();
	v=&m;
	v->start();
	v->stop();
	v=&t;
	v->start();
	v->stop();
	return 0;
}
