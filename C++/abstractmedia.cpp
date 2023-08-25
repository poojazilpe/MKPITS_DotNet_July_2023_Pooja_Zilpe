#include<iostream>
using namespace std;
class Mediaplayer
{
	public:
	virtual void play()=0;
	virtual void pause()=0;
	virtual void stop()=0;
};
class Audio:public Mediaplayer
{
	public:
		void play()
		{
			cout<<"Audio player is start"<<endl;
		}
		void pause()
		{
			cout<<"Audio player is pause"<<endl;
		}
		void stop()
		{
			cout<<"Audio player is stop"<<endl;
		}
};
class Vedio:public Mediaplayer
{
	public:
		void play()
		{
			cout<<"Vedio player is start"<<endl;
		}
		void pause()
		{
			cout<<"Vedio player is pause"<<endl;
		}
		void stop()
		{
			cout<<"Vedio player is stop"<<endl;
		}
};
int main()
{
	Audio a;
	Vedio v;
	a.play();
	a.pause();
	a.stop();
	v.play();
	v.pause();
	v.stop();
	return 0;
}
