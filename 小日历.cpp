// С����.cpp : �������̨Ӧ�ó������ڵ㡣
//


#include "stdafx.h"
#include <iomanip>
#include <ctime>
#include <iostream>
using namespace std;
void Showyear(int year)
{      int a[12]={31,28,31,30,31,30,31,31,30,31,30,31},b[12],r[6][14]={0},sum1=0,sum=0,count=0,m=1,n=1;
   if(year%400==0||(year%4==0)&&(year%100!=0))//���1940������������ڵ��������
	               a[1]=a[1]+1;
   if(year>1940)
         { for(int i=1940;i<=year-1;i++)
          if((i%400==0)||(i%4==0)&&(i%100!=0))
	       ++count;//�������������һ�µ���������·�֮��������
            sum1=(year-1940-count)*365+count*366 ;}//���������������֮�������֮�ͣ�
    for (int i=0;i<12;i++)
		   { for(int k=0;k<=i;k++)
	               {if(k==0)
				     sum=0;
				    else
					 sum=sum+a[k-1];}
	                if(6==(sum+sum1)%7)
			           b[i]=0;
		             else
	                   b[i]=((1+(sum+sum1)%7));
			           sum=0;
			}
    cout<<"|==================The Calendar Of Year "<<year<<" =====================|" <<endl;
	for(int j=0;j<6;j++)//ѭ������
	       { cout<<"| "<<j+1<<"  SUN MON TUE WED THU FRI SAT"<<setw(4)<<j+7<<"  "<<"SUN MON TUE WED THU FRI SAT"<<" |"<<endl;
			 for (int i=0;i<6;i++)
	        for(int k=0;k<14;k++)
	              { //��һ��
	                  if(i==0&&(k>=0&&k<b[j]||k>=7&&k<(b[j+6]+7)))
					       r[i][k]=0;
					  else//������
				       {if(k>=0&&k<=6)
					      {r[i][k]=m;m++;
					       if((m>a[j]+1))
					       r[i][k]=0;}
					    if(k>=7&&k<=13)
						  {r[i][k]=n;n++;
						  if(n>(a[j+6]+1))
						    r[i][k]=0;}}
			               
                 //ѭ�����
                   if(k==0)
						cout<<"|   ";
				  if(k==7)
					 cout<<"     ";
				   if(r[i][k]==0)cout<<"    ";
				   else 
					   cout<<setw(4)<<r[i][k];
				   if(k==13)cout<<" |"<<endl;
	           }n=1;m=1;
	       }
	cout<<"|=================================================================|"<<endl;
}
void Showmonth(int year,int month)//���ĳ�µ������ĺ���
{int sum=0,count=0;
 int a[12]={31,28,31,30,31,30,31,31,30,31,30,31};//һ��ÿ���·ݣ�
 if(year%400==0||(year%4==0)&&(year%100!=0))
	 a[1]=a[1]+1;
 if(year>1940)
    {for(int i=1940;i<=year-1;i++)
      {if((i%400==0)||(i%4==0)&&(i%100!=0))
	  ++count;}
    for(int i=0;i<month-1;i++)
            sum=sum+a[i];//�������������һ�µ���������·�֮��������
	   sum=(year-1940-count)*365+count*366+sum;//���������������֮�������֮�ͣ�
    }
 else
   {for(int i=0;i<month-1;i++) 
    sum=sum+a[i];
    }//����1940�꣬��ֱ����
 cout<<" SUN MON TUE WED THU FRI SAT"<<endl;
 int t=0,k=0;
 if (sum%7<6)
    { for (int i=0 ;i<1+sum%7 ;i++)
 {cout<<"    "; t++;}
    }//����������·ݵ�����֮ǰ�м����ո�
 for(int i=1;i<=12;i++)
 {k++;
 if(month==i)
	 break;}
 for(int i=1;i<=a[k-1];i++)
 {  cout<<setw(4)<<i;t++;
 if(t%7==0)
	 cout<<endl;}//�������
 cout<<endl;
}
int Showday(int year,int month ,int day )//���ĳ�����ڵ���Ϣ�ĺ���
  { int count,sum,m=0,n=0;
     count=sum=0;
	 tm*year1;
	 tm*month1;
	 tm*day1;
	 time_t t;
	 t=time(0);
	 year1=localtime(&t);
	 month1=localtime(&t);
	 day1=localtime(&t);
	 cout<<"month"<<  (month1->tm_mon+1)<<(day1->tm_mday)<<endl;
	 int a[12]={31,28,31,30,31,30,31,31,30,31,30,31};
	 if(year>(year1->tm_year+1900))//���������������2015��֮��
	    { for(int i=(year1->tm_year+1900)+1;i<year;i++)
	      if((i%400==0)||(i%4==0)&&(i%100!=0))
			  count++;
	          sum=365*(year-1-(year1->tm_year+1900))+count;//������2015�굽year֮���������
	      for(int i=1;i<month;i++)
			  m=m+a[i-1];//����֮��֮�ڣ�����֮��֮ǰ������
		  for(int b=12;b>(month1->tm_mon+1);b--)
			  n=n+a[b-1];//�����ڣ�����֮ǰ������
		     sum=sum+n+a[(month1->tm_mon+1)-1]-(day1->tm_mday)+m+day;//������
	     }//����������
	 
	 if (year==(year1->tm_year+1900))//���������
	      { if ((month==(month1->tm_mon+1))&&day>=(day1->tm_mday))//�����ڣ��ұ���֮��
	               sum=day-(day1->tm_mday);
		   else 
		       {if(month!=(month1->tm_mon+1))//����ͬһ��
			      {for (int i=month+1;i<(month1->tm_mon+1);i++)
		          sum=sum+a[i-1];
	              sum= a[month-1]-day+1+sum+(month1->tm_mon+1)-1;}
		        else //ͬһ���£����ڱ���֮ǰ
                  sum=(day1->tm_mday)-day;
	           }
	       }
	 if (year<(year1->tm_year+1900))//����֮ǰ
	    {  for(int i=(year1->tm_year+1900)-1;i>year;i--)  
	              count++;//������
	              sum=365*((year1->tm_year+1900)-year-1)+count;//������������֮���뱾��֮�䣩
		   for(int i=1;i<(month1->tm_mon+1);i++)
				  m=m+a[i-1];//�����ڣ�����֮ǰ������
		   for(int b=12;b>month;b--)
			      n=n+a[b-1];//����֮��֮�ڣ�����֮��֮�������
			      sum=sum+m+(day1->tm_mday)-1+n+a[month-1]-day+1;//������
	    }
	 cout<<"����������ھ����"<<sum<<"�졣"<<endl;//�������
  int sum1=count=0;
  if(year%400==0||(year%4==0)&&(year%100!=0))//���1940������������ڵ��������
	               a[1]=a[1]+1;
  if(year>1940)
     { for(int i=1940;i<=year-1;i++)
        {if((i%400==0)||(i%4==0)&&(i%100!=0))
	      ++count;}
       for(int i=0;i<month-1;i++)
          sum1=sum1+a[i];//�������������һ�µ���������·�֮��������
	      sum1=(year-1940-count)*365+count*366+sum1;//���������������֮�������֮�ͣ�
     }
  else
       { for(int i=0;i<month-1;i++) 
         sum1=sum1+a[i];}
         sum1=sum1+day-1;
	    //����1940�꣬��ֱ����
  if (sum1%7<6)
	      cout<<"�����������������"<<1+sum1%7<<endl;
  else
		  cout<<"������"<<endl;
  switch(month)
	 { case 1:if(day==1){cout<<"YES��Ԫ��"<<endl;break;}
	           else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;} 
	   case 2:if(day==14){cout<<"YES,���˽�"<<endl;break;}
			  else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 3:if(day==12){cout<<"YES��ֲ����"<<endl;break;}
			  else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 4:if (day==1){cout<<"YES,���˽�"<<endl;break;}
		   else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 5:if (day==1)
			     {cout<<"YES,�Ͷ���"<<endl;break;}
			  else 
			      {   if (day==4)
			            {cout<<"YES,�����"<<endl;break;}
			          else
			              {if (sum1%7==6&&day>=8)
			             {cout<<"YES��ĸ�׽�"<<endl;break;}
			              else 
			                {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}}
	   case 6:if (day==1)
			  {cout<<"YES����ͯ��"<<endl;break;}
			  else
			      {if(sum1%7==6&&day>=15)
			       {cout<<"YES�����׽�"<<endl;break;}
			       else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
			  }
	   case 7:if(day==1)
			  {cout<<"������"<<endl;break;}
			  else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 8:if(day==1)
			  {cout<<"������"<<endl;break;}
			  else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 9:if(day==10)
			  {cout<<"YES,��ʦ��"<<endl;break;}
			  else
				  {if(year>=2015&&day==13)
			     {cout<<"YES,��սʤ����"<<endl;break;}  
			            else 
			      cout<<"���������ڲ��ǹ������ա�"<<endl;break;}
	   case 10:if (day==1)
			   {cout<<"YES,�����"<<endl;break;}
	   case 12:if (day==13&&year>=2014)
			      {cout<<"YES,�Ͼ�����ɱ��"<<endl;break;}  
			   else 
			      {cout<<"���������ڲ��ǹ������ա�"<<endl;break;}

	   default:cout<<"���������ڲ��ǹ������ա�"<<endl;
				   
			  }  }  return sum1;cout<<endl;}
int _tmain(int argc, _TCHAR* argv[])
{   int number,year,month,day;
   while(1)
	{cout<<"����õ�ĳ��������Ļ����밴1��������õ�ĳ��ĳ�µ��������밴2��������õ�ĳ�յ���Ϣ���밴3��;����ֹͣ���밴4(�������ʽ��������������)��";
    cin>>number;
	switch (number)
		{case 1:do
				{cout<<"��������Ҫ֪����ĳ�꣨����ʽ�������ϵͳ��Ҫ�����ٴ����룩��";
					cin>>year; }while(year<1940||year>2040);
					Showyear(year);break;
		case 2: do
				{cout<<"��������Ҫ֪����ĳ��ĳ�£�����ʽ�������ϵͳ��Ҫ�����ٴ����룩��";
					cin>>year>>month; }while(year<1940||year>2040 ||month<=0||month>=13);
					Showmonth(year,month);break;
	    case 3: do
				{ cout<<"��������Ҫ֪����ĳ��ĳ��ĳ�գ�����ʽ�������ϵͳ��Ҫ�����ٴ����룩��";
				cin>>year>>month>>day;
				}while(year<1940||year>2040 ||month<=0||month>=13||day<=0||day>32);
				Showday(year,month,day);break;}
      if(number==4)
         break;}
	return 0;
}
