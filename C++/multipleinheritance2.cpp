#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abilityName;
		public:
			void getName(string an)
			{
				abilityName=an;
			}
};
class Equipment
{
	protected:
		string equipmentItem;
		public:
			void getequipmentItem(string ei)
			{
			equipmentItem=ei;	
			}
};
class Character:public Ability, public Equipment
{
	private:
		string characterName;
		public:
			void getcharacterName(string cn)
			{
				characterName=cn;
			}
			void display()
			{
				cout<<"Character Name ="<<characterName<<endl;
				cout<<"Equipment Name ="<<equipmentItem<<endl;
				cout<<"Ability ="<<abilityName;
			}
};
int main()
{
	Character c1;
	c1.getName("Attack");
	c1.getequipmentItem("gun");
	c1.getcharacterName("pooja");
	c1.display();
	return 0;
}

	


