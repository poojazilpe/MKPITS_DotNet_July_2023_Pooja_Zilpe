#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tiktacto:public Game
{
	public:
		void start()
		{
			cout<<"Tiktacto game is startted"<<endl;
		}
		void play()
		{
			cout<<"Tiktacto game is palyed"<<endl;
		}
		void end()
		{
			cout<<"Tiktacto game is stopped"<<endl;
		}
};
class Chess:public Game
{
	public:
		void start()
		{
			cout<<"Chess game is startted"<<endl;
		}
		void play()
		{
			cout<<"chess game is played"<<endl;
		}
		void end()
		{
			cout<<"Chess game is stopped"<<endl;
		}
};
int main()
{
	Tiktacto t;
	Chess c;
	t.start();
	t.play();
	t.end();
	c.start();
	c.play();
	c.end();
	return 0;
}
