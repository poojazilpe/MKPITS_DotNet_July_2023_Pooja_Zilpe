#include<iostream>
using namespace std;
class Ability
{
	private:
		string abilityName;
		public:
			void getName(string an)
			{
				abilityName=an;
			}
			void display()
			{
			cout<<"Ability ="<<abilityName<<endl;	
			}
};
class Equipment
{
	private:
		string equipmentItem;
		public:
			void getequipmentItem(string ei)
			{
			equipmentItem=ei;	
			}
			void display()
			{
			cout<<"Equipment Name ="<<equipmentItem<<endl;	
			}
};
class Character:public Ability, public Equipment
{
	private:
		string characterName;
		public:
			void getcharacterName(string cn,string an,string ei)
			{
				characterName=cn;
				getName(an);
				getequipmentItem(ei);
				
			}
			void display()
			{
				cout<<"Character Name ="<<characterName<<endl;
				Ability::display();
				Equipment::display();
				
			}
};
int main()
{
	Character c1;
	c1.getcharacterName("Pooja","Attack","Gun");
	c1.display();
	return 0;
}

	


