#include<iostream>
using namespace std;
class Animal
{
	public:
		virtual void sound()
		{
			cout<<"Animal Sound:"<<endl;
		}
		
};
class Dog:public Animal
{
	public:
		void sound()
		{
		cout<<"Dog sound is Woof-woof"<<endl;	
		}
};
class Cat:public Animal
{
	public:
		void sound()
		{
			cout<<"Cat sound is meow-meow"<<endl;
		}
};
class Cow:public Animal
{
	public:
		void sound()
		{
			cout<<"Cow sound is moo-moo"<<endl;
		}
};
int main()
{
	Animal *a;
	Animal a1;
	Cat c;
	Dog d;
	Cow c1;
	a=&a1;
	a->sound();
	a=&d;
	a->sound();
	a=&c;
	a->sound();
	a=&c1;
	a->sound();
	return 0;
}
