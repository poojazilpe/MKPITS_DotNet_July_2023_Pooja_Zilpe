#include<iostream>
using namespace std;
class Engine
{
	protected:
		string power;
		public:
			void getpower(string p)
			{
				power=p;
			}
			void start()
			{
				cout<<"Engin is started"<<endl;
			}
			void stop()
			{
				cout<<"Engine is stop"<<endl;
			}
};
class Vehicle
{
	protected:
		string brand;
		public:
			void getbrand(string b)
			{
				brand=b;
			}
		void accelerator()
		{
			cout<<"Accelerating"<<endl;
		}
		void brake()
		{
			cout<<"Brake"<<endl;
		}
		void display()
		{
			cout<<"Brand :"<<brand<<endl;
		}
};
class Car:public Engine, public Vehicle
{
	public:
		void drive()
		{
		cout<<"Car is driving"<<endl;	
		}
		void park()
		{
			cout<<"Car is parking"<<endl;
		}
};
int main()
{
	Car c1;
	c1.getbrand("Hondacity");
	c1.display();
	c1.start();
	c1.drive();
	c1.accelerator();
	c1.brake();
	c1.park();
	c1.stop();
	return 0;
}
