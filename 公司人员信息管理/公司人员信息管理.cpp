// 公司人员信息管理.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include"employee.h"
#include"technician.h"
#include"manager.h"
#include"salesman.h"
#include"salesmanager.h"
#include<fstream>
#include<iostream>
#include<string>
#include<fstream>
#include<vector>
using namespace std;

employee *p=NULL;

void  fun_substr1(fstream &file,string str_sep ,vector <string> &vec)
{
	int count =0;
	string str = "";
	string str_temp = "";
	int pos = 0;
	int sep_len = str_sep.length();
	int i=0;
	while(getline(file,str))
	{
	    pos = str.find(str_sep);
		vec.push_back(str.substr(0,pos));
		str_temp = str.substr(pos+1,str.length()-pos-sep_len);
		pos = str_temp.find(str_sep);
			while(str_temp.compare("")&& (pos!=-1)){
			i++;
		vec.push_back(str_temp.substr(0,pos));
		str_temp = str_temp.substr(pos+1,str_temp.length()-pos-sep_len);
		pos = str_temp.find(str_sep);
		}
		vec.push_back(str_temp);
	}
}
void  fun_substr2(fstream &file2,string str_sep2 ,vector <string> &vec2)
{
	int count =0;
	string str2 = "";
	string str_temp2 = "";
	int pos2= 0;
	int sep_len2 = str_sep2.length();
	int i=0;
	while(getline(file2,str2)){
	    pos2 = str2.find(str_sep2);
		vec2.push_back(str2.substr(0,pos2));
		str_temp2 = str2.substr(pos2+1,str2.length()-pos2-sep_len2);
		pos2 = str_temp2.find(str_sep2);
			while(str_temp2.compare("")&& (pos2!=-1)){
			i++;
		vec2.push_back(str_temp2.substr(0,pos2));
		str_temp2 = str_temp2.substr(pos2+1,str_temp2.length()-pos2-sep_len2);
		pos2 = str_temp2.find(str_sep2);
		}
		vec2.push_back(str_temp2);
	}
}
void  fun_substr3(fstream &file3,string str_sep3 ,
	vector <string> &vec3){
	int count =0;
	string str3 = "";
	string str_temp3 = "";
	int pos3 = 0;
	int sep_len3 = str_sep3.length();
	int i=0;
	while(getline(file3,str3)){
	    pos3 = str3.find(str_sep3);
		vec3.push_back(str3.substr(0,pos3));
		str_temp3 = str3.substr(pos3+1,str3.length()-pos3-sep_len3);
		pos3 = str_temp3.find(str_sep3);
			while(str_temp3.compare("")&& (pos3!=-1)){
			i++;
		vec3.push_back(str_temp3.substr(0,pos3));
		str_temp3 = str_temp3.substr(pos3+1,str_temp3.length()-pos3-sep_len3);
		pos3 = str_temp3.find(str_sep3);
		}
		vec3.push_back(str_temp3);
	}
}
void  fun_substr4(fstream &file4,string str_sep4 ,
	vector <string> &vec4){
	int count =0;
	string str4 = "";
	string str_temp4 = "";
	int pos4 = 0;
	int sep_len4 = str_sep4.length();
	int i=0;
	while(getline(file4,str4)){
	    pos4 = str4.find(str_sep4);
		vec4.push_back(str4.substr(0,pos4));
		str_temp4 = str4.substr(pos4+1,str4.length()-pos4-sep_len4);
		pos4= str_temp4.find(str_sep4);
			while(str_temp4.compare("")&& (pos4!=-1)){
			i++;
		vec4.push_back(str_temp4.substr(0,pos4));
		str_temp4 = str_temp4.substr(pos4+1,str_temp4.length()-pos4-sep_len4);
		pos4 = str_temp4.find(str_sep4);
		}
		vec4.push_back(str_temp4);
	}
}
void class_technician()
{  char decide;
   int choice=0;
   bool quit=false;  
   
   while(1)
   {
	   system("cls");
       cout<<"       **********技术人员信息子菜单*********"<<endl;
	   cout<<"      **                                   **"<<endl;   
	   cout<<"     **            1.查看人员信息           **"<<endl;
	   cout<<"    **                                       **"<<endl; 
       cout<<"   **              2.添加人员信息             **"<<endl;
	   cout<<"  **                                           **"<<endl;
       cout<<"  **               3.修改人员信息              **"<<endl;
	   cout<<"   **                                         **"<<endl;
       cout<<"    **             4.删除人员信息            **"<<endl; 
	   cout<<"     **                                     **"<<endl;
	   cout<<"      **           0.退出                  **"<<endl;
       cout<<"       *************************************"<<endl;
       cout<<"        @@@@@@@请输入所要操作的编号@@@@@@@：";
       cin>>choice;   
       switch(choice)
	   {
	  case 1:			    
			{
				technician tech;
				p=&tech;
				p->read();
				p->save();
				p->read();
				p->print();
				cout<<"技术人员总人数为：";
				p->display();
				
				system("pause");
	            break;
			}
        case 2:			    
			{
				technician tech;
				p=&tech;
				p->read();
	            p->add();
				if(p->decide_w())
				break;
				else
				{
				cout<<"是否保存人员信息？(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				    p->save();
				}  
				system("pause");
	            break;
				}
			}
	    case 3:
			{
				technician tech;
				p=&tech;
				p->read();
				if(p->modify()){
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				   p->save();
				} 
				system("pause");
				 break;
				}else{
				cout<<"记录为空!"<<endl;
				system("pause");
				 break;
				}			
			   
			}
	    case 4:
			{
				technician tech;
				p=&tech;		
				p->read();
			    if(p->del()){
				cout<<"是否保存人员信息？(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				 p->save();	 
				}			
				break;}else{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}
			}
		case 0:quit=true;break;
	    default:cout<<"根据功能输入对应数字："<<endl; break; 
	   }
	   if(quit==true)
		   break;	     
   }
   system("cls"); 
   
}
void class_salesman()
{  char decide;
   int choice=0;
   bool quit=false;  
   
   while(1)
   {
	   system("cls"); 
       cout<<"       ********销售人员信息子菜单*********"<<endl;
	   cout<<"      **                                 **"<<endl;
	   cout<<"     **           1.查看人员信息          **"<<endl;
	   cout<<"    **                                     **"<<endl;
	   cout<<"   **             2.添加人员信息            **"<<endl;
	   cout<<"  **                                         **"<<endl;
       cout<<" **               3.修改人员信息              **"<<endl;
	   cout<<"  **                                         **"<<endl;
       cout<<"   **             4.删除人员信息            **"<<endl; 
	   cout<<"    **                                     **"<<endl;
	   cout<<"     **           0.退出                  **"<<endl;
       cout<<"       ************************************"<<endl;
       cout<<"          @@@@@请输入所要操作的编号@@@@@：";
       cin>>choice;   
       switch(choice)
	   {
	  case 1:			    
			{
				salesman sal;
				p=&sal;
				p->read();
				p->save();
				p->read();
				p->print();
				cout<<"销售人员总人数：";
				p->display();
				
				system("pause");
	            break;
			}
        case 2:			    
			{
				salesman sal;
				p=&sal;
				p->read();
	            p->add();
				if(p->decide_w())
				break;
				else
				{
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				    p->save();
				}  
				system("pause");
	            break;
				}
			}
	    case 3:
			{
				salesman sal;
				p=&sal;
				p->read();
				if(p->modify())
				{
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				   p->save();
				 
				} 
				system("pause");
				 break;
				}
				else
				{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}			
			   
			}
	    case 4:
			{
				salesman sal;
				p=&sal;		
				p->read();
			    if(p->del()){
				cout<<"是否保存人员信息？(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				 p->save();	 
				}			
				break;}else{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}
			}
		case 0:quit=true;break;
	    default:cout<<"根据功能输入对应数字："<<endl; break; 
	   }
	   if(quit==true)
		   break;	     
   }
   system("cls"); 
   
}
void class_manager()
{  char decide;
   int choice=0;
   bool quit=false;  
   while(1)
   {
	   system("cls");
       cout<<"      **********经理信息子菜单*********"<<endl;
	   cout<<"     **                               **"<<endl;
	   cout<<"    **            1.查看人员信息       **"<<endl;
	   cout<<"   **                                   **"<<endl;
       cout<<"  **              2.添加人员信息         **"<<endl; 
	   cout<<" **                                       **"<<endl;
       cout<<"**                3.修改人员信息           **"<<endl;
	   cout<<"**                                         **"<<endl;
       cout<<" **               4.删除人员信息          **"<<endl; 
	   cout<<"  **                                     **"<<endl;
	   cout<<"   **             0.退出                **"<<endl;
	   cout<<"     **                               **"<<endl;
	   cout<<"      *********************************"<<endl;
       cout<<"       @@@@@请输入所要操作的编号@@@@@：";
       cin>>choice;   
       switch(choice)
	   {
	  case 1:			    
			{
				manager man;
				p=&man;
				p->read();
				p->save();
				p->read();
				p->print();
				cout<<"经理总人数：";
				p->display();
				
				system("pause");
	            break;
			}
        case 2:			    
			{
				manager man;
				p=&man;
				p->read();
	            p->add();
				if(p->decide_w())
				break;
				else
				{
				cout<<"是否保存人员信息？(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				    p->save();
				}  
				system("pause");
	            break;
				}
			}
	    case 3:
			{
				manager man;
				p=&man;
				p->read();
				if(p->modify()){
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				   p->save();
				} 
				system("pause");
				 break;
				}else{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}			
			   
			}
	    case 4:
			{
				manager man;
				p=&man;		
				p->read();
			    if(p->del())
				{
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				 p->save();	 
				}			
				break;
				}
				else
				{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}
			}
		case 0:quit=true;break;
	    default:cout<<"根据功能输入对应数字："<<endl; break; 
	   }
	   if(quit==true)
		   break;	     
   }
   system("cls"); 
   
}
void class_salesmanager()
{  char decide;
   int choice=0;
   bool quit=false;  
   while(1)
   {
	   system("cls"); 
       cout<<"      **********销售经理信息子菜单*********"<<endl;
	   cout<<"     **                                   **"<<endl;
	   cout<<"    **            1.查看人员信息           **"<<endl;
	   cout<<"   **                                       **"<<endl;
	   cout<<"  **              2.添加人员信息             **"<<endl;
	   cout<<" **                                           **"<<endl;
	   cout<<"**                3.修改人员信息               **"<<endl;
	   cout<<" **                                           **"<<endl;
	   cout<<"  **              4.删除人员信息             **"<<endl;
	   cout<<"   **                                       **"<<endl;
	   cout<<"    **            0.退出                   **"<<endl;
	   cout<<"     **                                  **"<<endl;
       cout<<"      ************************************"<<endl;
       cout<<"       @@@@@@请输入所要操作的编号：@@@@@";
       cin>>choice;   
       switch(choice)
	   {
	  case 1:			    
			{
				salesmanager sama;
				p=&sama;
				p->read();
				p->save();
				p->read();
				p->print();
				cout<<"销售经理总人数：";
				p->display();
				
				system("pause");
	            break;
			}
        case 2:			    
			{
				salesmanager sama;
				p=&sama;
				p->read();
	            p->add();
				if(p->decide_w())
				break;
				else
				{
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				    p->save();
				}  
				system("pause");
	            break;
				}
			}
	    case 3:
			{
				salesmanager sama;
				p=&sama;
				p->read();
				if(p->modify()){
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				   p->save();
		
				} 
				system("pause");
				 break;
				}else{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}			
			   
			}
	    case 4:
			{
				salesmanager sama;
				p=&sama;		
				p->read();
			    if(p->del())
				{
				cout<<"是否保存人员信息?(y/n)\n";
	            cin>>decide;
	            if(decide=='y')
				{
				 p->save();	 
				}			
				break;
				}
				else
				{
				cout<<"记录为空！"<<endl;
				system("pause");
				 break;
				}
			}
		case 0:quit=true;break;
	    default:cout<<"根据功能输入对应数字："<<endl; break; 
	   }
	   if(quit==true)
		   break;	     
   }
   system("cls"); 
   
}

int _tmain(int argc, _TCHAR* argv[])
{
	int choice=1;  
   while(1)
   {
cout<<"           $$$$&&&&&&&&&&&&&&主菜单&&&&&&&&&&"<<endl;
cout<<"       **             1.技术人员信息管理      **"<<endl;
cout<<"     **                                         **"<<endl;
cout<<"   **              2.销售人员信息管理             **"<<endl;
cout<<" **                                                 **"<<endl;
cout<<"**               3.经理信息管理                      **"<<endl;
cout<<"**                                                   **"<<endl;
cout<<" **             4.销售经理信息管理                  **"<<endl;
cout<<"  **                                               **"<<endl;
cout<<"   **         5.人数统计                          **"<<endl;
cout<<"     **                                         **"<<endl;
cout<<"        **  0.退出                          **"<<endl;
cout<<"           ********************************"<<endl;
cout<<"                 请输入所要操作的编号：";
   cin>>choice;
   switch(choice)
   {
      case 1: class_technician();break;
	  case 2:class_salesman();break;
	  case 3:class_manager();break;
	  case 4:class_salesmanager();break;
	  case 5:
		 {
			 technician te;te.read();
	         salesman sa;sa.read();
	         manager ma;ma.read();
	         salesmanager sa_m; sa_m.read();
			 int ALL_P=technician::count_t+manager::count_m+salesman::count_s+salesmanager::count_s_m;
		     cout<<"该公司总人数："<<ALL_P<<endl;
			 system("pause");system("cls"); }break;
      case 0: cout<<"谢谢您的使用！"<<endl; return 0;break;
      default:cout<<"请输入0~5之间的数字！"<<endl;break;  
   }
  }  
	system("pause");
	return 0;
	return 0;
}

