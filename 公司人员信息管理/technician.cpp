#include "StdAfx.h"
#include "technician.h"
#include<fstream>
#include<sstream>
#include<string>
#include<iostream>
using namespace std;
int q;
const int maxtechnician=10;
int technician::count_t=0;
technician t[maxtechnician];

technician::technician(int w_)
{
	
	w=w_;
}
technician::~technician(void)
{
}
void technician::v_salary()
{
	salary=hour*hoursalary;
}
string Convert1(float salary)
{	
	ostringstream oss;	
	oss<<salary;	
	string str_s1(oss.str());	
	return str_s1;
}
void technician::read()
{
	fstream iofile("技术人员.txt",ios::in|ios::out);
	vector<string>vec;
	fun_substr1(iofile,"	",vec);
	int i,j;
	for(i=0,j=0;i<vec.size();i=i+6,j++)
	{
		t[j].name=vec[i];
		t[j].number=vec[i+1];
		t[j].sex=vec[i+2];
		t[j].department=vec[i+3];
		t[j].level=vec[i+4];
		t[j].str_s1=vec[i+5];
	}
	count_t=j;
	iofile.close();
}
void technician::add()
{

	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号：";
	cin>>number;
	for(int i=0;i<count_t;i++)
	{
		if(number==t[i].number)
		{
			cout<<"输入的编号重复"<<endl;
			w=1;
		}
		else
			continue;
	}	
	if(!w)
	{
	cout<<"输入性别：";
	cin>>sex;
	cout<<"输入所属部门：";
	cin>>department;
	cout<<"输入级别：";
	cin>>level;
	cout<<"输入小时数：";
	cin>>hour;
	cout<<"输入每小时工资：";
	cin>>hoursalary;
	t[count_t].name=name;
	t[count_t].number=number;
	t[count_t].sex=sex;
	t[count_t].department=department;
	t[count_t].level=level;
	v_salary();
	t[count_t].salary=salary;
	count_t++;
	}
	else
		system("pause");
	
}
bool technician::modify(){
	bool flag = true;
	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号：";
	cin>>number;
	for(int i=0;i<count_t;i++)
	{
		if(!t[i].name.compare(name)&&!t[i].number.compare(number))
		{
		cout<<"输入修改后性别：";
	    cin>>sex;
		cout<<"输入修改后的部门：";
		cin>>department;
		cout<<"输入修改后的级别：";
		cin>>level;
		cout<<"输入修改后的工作时间：";
		cin>>hour;
		cout<<"输入修改后的每小时工资：";
			cin>>hoursalary;
	    t[i].sex=sex;
	    t[i].department=department;
	    t[i].level=level;
		v_salary();
	    q=i;
		flag = true;
		break;
		}
		else
		{
		flag = false;
		}
	}
	return flag;
}
bool technician::del(){
	bool flag = true;
	cout<<"请输入编号：";
	cin>>number;
	int people;
	for(int i=0;i<count_t;i++)
	{
		if(!t[i].number.compare(number))
		{
		people = i;
		for(int i=people;i<=count_t-1;i++)
		{
		t[i].name=t[i+1].name;
	    t[i].number=t[i+1].number;
	    t[i].sex=t[i+1].sex;
		t[i].department=t[i+1].department;
	    t[i].level=t[i+1].level;
	    t[i].salary=t[i+1].salary;
			flag = true;
			break;
		}
		break;
		}else{
		flag = false;
		}
}
	count_t--;
	return flag;
}
void technician::save(){
	ofstream outfile;
	outfile.open("技术人员.txt",ios::out);
	for(int i=0;i<count_t;i++){
		outfile<<t[i].name<<"	"<<t[i].number<<"	"<<t[i].sex<<"	"<<t[i].department<<"	"<<t[i].level<<"	"<<t[i].salary<<endl;
	}
    outfile.close();
}
void technician::print(){

	for(int i=0;i<count_t;i++)
{
		cout<<"姓名："<<t[i].name<<endl;
		cout<<"编号："<<t[i].number<<endl;
		cout<<"性别： "<<t[i].sex<<endl;
		cout<<"所属部门："<<t[i].department<<endl;
		cout<<"级别："<<t[i].level<<endl;
		cout<<"工资情况:"<<t[i].salary<<endl;
	}
}
int technician::decide_w()
{
	return w;
}
void technician::display()
{
	cout<<count_t;
	
}