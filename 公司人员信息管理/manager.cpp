#include "StdAfx.h"
#include "manager.h"
#include<fstream>
#include<sstream>
#include<string>
#include<iostream>
using namespace std;
int q3;
const int maxmanager=10;
int manager::count_m=0;
manager m[maxmanager];
manager::manager(int w_)
{

	w=w_;
}
manager::~manager(void)
{
}
void manager::v_salary()
{
	salary=fixsalary;
}
string Convert3(float salary)
{	
	ostringstream oss;	
	oss<<salary;	
	string str_s3(oss.str());	
	return str_s3;
}
void manager::read()
{
	fstream iofile3("经理.txt",ios::in|ios::out);
	vector<string>vec3;
	fun_substr3(iofile3,"	",vec3);
	int i,j;
	for(i=0,j=0;i<vec3.size();i=i+6,j++)
	{
		m[j].name=vec3[i];
		m[j].number=vec3[i+1];
		m[j].sex=vec3[i+2];
		m[j].department=vec3[i+3];
		m[j].level=vec3[i+4];
		m[j].str_s3=vec3[i+5];
	}
	count_m=j;
	iofile3.close();
}
void manager::add()
{

	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号：";
	cin>>number;
	for(int i=0;i<count_m;i++)
	{
		if(number==m[i].number)
		{
			cout<<"输入编号重复："<<endl;
			w=1;
		}
		else
			continue;
	}	
	if(!w)
	{
	cout<<"输入姓名：";
	cin>>sex;
	cout<<"输入所属部门：";
	cin>>department;
	cout<<"输入级别：";
	cin>>level;
	cout<<"输入固定工资：";
	cin>>fixsalary;
	m[count_m].name=name;
	m[count_m].number=number;
	m[count_m].sex=sex;
	m[count_m].department=department;
	m[count_m].level=level;
	v_salary();
	m[count_m].salary=salary;
	count_m++;
	}
	else
		system("pause");
	
}
bool manager::modify(){
	bool flag3 = true;
	cout<<"输入姓名：";
	cin>>name;
	cout<<"输入编号:";
	cin>>number;
	for(int i=0;i<count_m;i++)
	{
		if(!m[i].name.compare(name)&&!m[i].number.compare(number))
		{
		cout<<"输入修改后性别";
	    cin>>sex;
		cout<<"输入修改后的部门：";
		cin>>department;
		cout<<"输入修改后的级别：";
		cin>>level;
		cout<<"输入修改后的固定工资：";
		cin>>fixsalary;
	    m[i].sex=sex;
	    m[i].department=department;
	    m[i].level=level;
		v_salary();
	    q3=i;
		flag3 = true;
		break;
		}
		else
		{
		flag3 = false;
		}
	}
	return flag3;
}
bool manager::del(){
	bool flag3 = true;
	cout<<"请输入编号：";
	cin>>number;
	int people3;
	for(int i=0;i<count_m;i++)
	{
		if(!m[i].number.compare(number))
		{
		people3 = i;
		for(int i=people3;i<=count_m-1;i++)
		{
		m[i].name=m[i+1].name;
	    m[i].number=m[i+1].number;
	    m[i].sex=m[i+1].sex;
		m[i].department=m[i+1].department;
	    m[i].level=m[i+1].level;
	    m[i].salary=m[i+1].salary;
			flag3 = true;
			break;
		}
		break;
		}else{
		flag3 = false;
		}
}
	count_m--;
	return flag3;
}
void manager::save(){
	ofstream outfile3;
	outfile3.open("经理.txt",ios::out);
	for(int i=0;i<count_m;i++){
		outfile3<<m[i].name<<"	"<<m[i].number<<"	"<<m[i].sex<<"	"<<m[i].department<<"	"<<m[i].level<<"	"<<m[i].salary<<endl;
	}
    outfile3.close();
}
void manager::print(){

	for(int i=0;i<count_m;i++){
	
		cout<<"姓名："<<m[i].name<<endl;
		cout<<"编号："<<m[i].number<<endl;
		cout<<"性别："<<m[i].sex<<endl;
		cout<<"所属部门："<<m[i].department<<endl;
		cout<<"级别："<<m[i].level<<endl;
		cout<<"工资情况："<<m[i].salary<<endl;
	}
}
int manager::decide_w()
{
	return w;
}
void manager::display()
{}