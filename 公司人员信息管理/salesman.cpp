#include "StdAfx.h"
#include "salesman.h"
#include<fstream>
#include<sstream>
#include<string>
#include<iostream>
using namespace std;
int q2;
const int maxsalesman=10;
int salesman::count_s=0;
salesman s[maxsalesman];
salesman::salesman(int w_)
{

	w=w_;
}
salesman::~salesman(void)
{
}
void salesman::v_salary()
{
	salary=sales*(double)commission;
}
string Convert2(float salary)
{	
	ostringstream oss;	
	oss<<salary;	
	string str_s2(oss.str());	
	return str_s2;
}
void salesman::read()
{
	fstream iofile2("������Ա.txt",ios::in|ios::out);
	vector<string>vec2;
	fun_substr2(iofile2,"	",vec2);
	int i,j;
	for(i=0,j=0;i<vec2.size();i=i+6,j++)
	{
		s[j].name=vec2[i];
		s[j].number=vec2[i+1];
		s[j].sex=vec2[i+2];
		s[j].department=vec2[i+3];
		s[j].level=vec2[i+4];
		s[j].str_s2=vec2[i+5];
	}
	count_s=j;
	iofile2.close();
}
void salesman::add()
{

	cout<<"����������";
	cin>>name;
	cout<<"�����ţ�";
	cin>>number;
	for(int i=0;i<count_s;i++)
	{
		if(number==s[i].number)
		{
			cout<<"����ı���ظ�"<<endl;
			w=1;
		}
		else
			continue;
	}	
	if(!w)
	{
	cout<<"�����Ա�";
	cin>>sex;
	cout<<"�����������ţ�";
	cin>>department;
	cout<<"���뼶��";
	cin>>level;
	cout<<"���뱾�����۶";
	cin>>sales;
	cout<<"������ɣ�";
	cin>>commission;
	s[count_s].name=name;
	s[count_s].number=number;
	s[count_s].sex=sex;
	s[count_s].department=department;
	s[count_s].level=level;
	v_salary();
	s[count_s].salary=salary;
	count_s++;
	}
	else
		system("pause");
	
}
bool salesman::modify(){
	bool flag2 = true;
	cout<<"����������";
	cin>>name;
	cout<<"�����ţ�";
	cin>>number;
	for(int i=0;i<count_s;i++)
	{
		if(!s[i].name.compare(name)&&!s[i].number.compare(number))
		{
		cout<<"�����޸ĺ��Ա�";
	    cin>>sex;
		cout<<"�����޸ĺ�Ĳ��ţ�";
		cin>>department;
		cout<<"�����޸ĵļ���";
		cin>>level;
		cout<<"�����޸ĺ�����۶";
		cin>>sales;
		cout<<"�����޸ĺ����ɣ�";
		cin>>commission;
	    s[i].sex=sex;
	    s[i].department=department;
	    s[i].level=level;
		v_salary();
	  q2=i;
		flag2 = true;
		break;
		}
		else
		{
		flag2 = false;
		}
	}
	return flag2;
}
bool salesman::del(){
	bool flag2 = true;
	cout<<"�������ţ�";
	cin>>number;
	int people2;
	for(int i=0;i<count_s;i++)
	{
		if(!s[i].number.compare(number))
		{
		people2 = i;
		for(int i=people2;i<=count_s-1;i++)
		{
		s[i].name=s[i+1].name;
	    s[i].number=s[i+1].number;
	    s[i].sex=s[i+1].sex;
		s[i].department=s[i+1].department;
	    s[i].level=s[i+1].level;
	    s[i].salary=s[i+1].salary;
			flag2 = true;
			break;
		}
		break;
		}else{
		flag2 = false;
		}
}
	count_s--;
	return flag2;
}
void salesman::save(){
	ofstream outfile2;
	outfile2.open("������Ա.txt",ios::out);
	for(int i=0;i<count_s;i++){
		outfile2<<s[i].name<<"	"<<s[i].number<<"	"<<s[i].sex<<"	"<<s[i].department<<"	"<<s[i].level<<"	"<<s[i].salary<<endl;
	}
    outfile2.close();
}
void salesman::print(){

	for(int i=0;i<count_s;i++){
	
		cout<<"������"<<s[i].name<<endl;
		cout<<"��ţ�"<<s[i].number<<endl;
		cout<<"�Ա�"<<s[i].sex<<endl;
		cout<<"�������ţ�"<<s[i].department<<endl;
		cout<<"����"<<s[i].level<<endl;
		cout<<"���������"<<s[i].salary<<endl;
	}
}
int salesman::decide_w()
{
	return w;
}
void salesman::display()
{
	cout<<count_s;

}
