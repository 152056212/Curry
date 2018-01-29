#include "StdAfx.h"
#include "salesmanager.h"
#include<fstream>
#include<sstream>
#include<string>
#include<iostream>
using namespace std;
int q4;
const int maxsalesmanager=10;
int salesmanager::count_s_m=0;
salesmanager s_m[maxsalesmanager];
salesmanager::salesmanager(int w_)
{
	w=w_;
}
salesmanager::~salesmanager(void)
{
}
void salesmanager::v_salary()
{
	salary=fixsalary+sales*commission;
}
string Convert4(float salary)
{	
	ostringstream oss;	
	oss<<salary;	
	string str_s4(oss.str());	
	return str_s4;
}
void salesmanager::read()
{
	fstream iofile4("销售经理.txt",ios::in|ios::out);
	vector<string>vec4;
	fun_substr4(iofile4,"	",vec4);
	int i,j;
	for(i=0,j=0;i<vec4.size();i=i+6,j++)
	{
		s_m[j].name=vec4[i];
		s_m[j].number=vec4[i+1];
		s_m[j].sex=vec4[i+2];
		s_m[j].department=vec4[i+3];
		s_m[j].level=vec4[i+4];
		s_m[j].str_s3=vec4[i+5];
	}
	count_s_m=j;
	iofile4.close();
}
void salesmanager::add()
{
	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号：";
	cin>>number;
	for(int i=0;i<count_s_m;i++)
	{
		if(number==s_m[i].number)
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
	cout<<"输入本月销售额：";
	cin>>sales;
	cout<<"输入提成：";
	cin>>commission;
	cout<<"输入固定工资:";
		cin>>fixsalary;
	s_m[count_s_m].name=name;
	s_m[count_s_m].number=number;
	s_m[count_s_m].sex=sex;
	s_m[count_s_m].department=department;
	s_m[count_s_m].level=level;
	v_salary();
	s_m[count_s_m].salary=salary;
	count_s_m++;
	}
	else
		system("pause");
}
bool salesmanager::modify(){
	bool flag4 = true;
	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号：";
	cin>>number;
	for(int i=0;i<count_s_m;i++)
	{
		if(!s_m[i].name.compare(name)&&!s_m[i].number.compare(number))
		{
		cout<<"输入修改后性别：";
	    cin>>sex;
		cout<<"输入修改后的部门：";
		cin>>department;
		cout<<"输入修改后的级别：";
		cin>>level;
		cout<<"输入修改后的销售额：";
		cin>>sales;
		cout<<"输入修改后的提成：";
		cin>>commission;
		cout<<"输入修改后的固定工资：";
		cin>>fixsalary;
	    s_m[i].sex=sex;
	    s_m[i].department=department;
	    s_m[i].level=level;
		v_salary();
	    q4=i;
		flag4 = true;
		break;
		}
		else
		{
		flag4 = false;
		}
	}
	return flag4;
}
bool salesmanager::del(){
	bool flag4 = true;
	cout<<"请输入编号:";
	cin>>number;
	int people4;
	for(int i=0;i<count_s_m;i++)
	{
		if(!s_m[i].number.compare(number))
		{
		people4 = i;
		for(int i=people4;i<=count_s_m-1;i++)
		{
		s_m[i].name=s_m[i+1].name;
	    s_m[i].number=s_m[i+1].number;
	    s_m[i].sex=s_m[i+1].sex;
		s_m[i].department=s_m[i+1].department;
	    s_m[i].level=s_m[i+1].level;
	    s_m[i].salary=s_m[i+1].salary;
			flag4= true;
			break;
		}
		break;
		}else{
		flag4 = false;
		}
}
	count_s_m--;
	return flag4;
}
void salesmanager::save(){
	ofstream outfile4;
	outfile4.open("销售经理.txt",ios::out);
	for(int i=0;i<count_s_m;i++){
		outfile4<<s_m[i].name<<"	"<<s_m[i].number<<"	"<<s_m[i].sex<<"	"<<s_m[i].department<<"	"<<s_m[i].level<<"	"<<s_m[i].salary<<endl;
	}
    outfile4.close();
}
void salesmanager::print()
{
	for(int i=0;i<count_s_m;i++)
{
		cout<<"姓名："<<s_m[i].name<<endl;
		cout<<"编号："<<s_m[i].number<<endl;
		cout<<"性别："<<s_m[i].sex<<endl;
		cout<<"所属部门："<<s_m[i].department<<endl;
		cout<<"级别："<<s_m[i].level<<endl;
		cout<<"工资情况："<<s_m[i].salary<<endl;
	}
}
int salesmanager::decide_w()
{
	return w;
}
void salesmanager::display()
{
	cout<<count_s_m;
	
}