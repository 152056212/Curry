package com.example.admit.amaptest.Mine;

import android.content.DialogInterface;
import android.os.Bundle;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.text.TextUtils;
import android.util.Log;
import android.util.Xml;
import android.view.View;
import android.view.Window;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RelativeLayout;
import android.widget.Toast;

import com.example.admit.amaptest.R;

import org.json.JSONObject;
import org.xmlpull.v1.XmlPullParser;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;

public class GetAddActivity extends AppCompatActivity implements View.OnClickListener,RadioGroup.OnCheckedChangeListener{
    /**
     * 添加信息
     * Add方式
     */


    private static final String TAG = "XML";
   private static boolean a = true;
    private byte[]s = null;
    private byte[] message=null;
    private static String m;
    private static String []num;
    private static String []num1;
    private static String []num2;
    private static String num3;
    private static String num4;
    private Button tj;
    private  Button chaxun;
   private static String str1;
    private static String str2;
    private static String str3;
    private static  String str4;
    private static  String str5;
    private static String xingbie;
    private static String type;
    private RelativeLayout tousufanhui;
    private static  String str6;
    private static  String str7;
    private static  String str8;
    private static  String str9;
    private static  String str10;
    private static  String str11;
    private static  String str12;
    private static  String str13;
    private static  String str14;
    private static  String str15;
    private static  String str16;

    EditText bianma;
    EditText biaoti;
    EditText neirong;
    EditText phone;
    private static
    EditText name;
    EditText email;
    RadioGroup sex;
    EditText huifu;
    EditText inputbianma;





    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_liuyan);
        tj= (Button) findViewById(R.id.tijiao);
        tj.setOnClickListener(this);
        chaxun= (Button) findViewById(R.id.chaxun);
        chaxun.setOnClickListener(this);
        sex = (RadioGroup) findViewById(R.id.sex);
        bianma= (EditText) findViewById(R.id.bianma_ed);

        sex.setOnCheckedChangeListener(this);

        //Editext判空
        inputbianma= (EditText) findViewById(R.id.bianma_ed);
        biaoti= (EditText) findViewById(R.id.biaoti_ed);
        neirong= (EditText) findViewById(R.id.neirong_ed);
        phone= (EditText) findViewById(R.id.phone_ed);
        name= (EditText) findViewById(R.id.name_ed);
        email= (EditText) findViewById(R.id.email_ed);
        tousufanhui = (RelativeLayout) findViewById(R.id.tousufanhui);
        tousufanhui.setOnClickListener(this);
        huifu= (EditText) findViewById(R.id.huifu);
    }
    // Get方式请求
    public static  byte[] requestBYGet()throws  Exception{
        String path="http://xdssgj.cn/gbook/messageBoard.asmx/add?title="+str1+"&contents="+str2+"&muser="+str3+"&cclass="+22+"&sex="+xingbie+"&phone="+str4+"&email="+str5;
        byte[] data = null;
        // 新建一个URL对象

        URL url=new URL(path);
        // 打开一个HttpURLConnection连接
        HttpURLConnection urlConn = (HttpURLConnection) url.openConnection();
        // 设置连接超时时间
        urlConn.setConnectTimeout(5000);
        //开始连接
        urlConn.connect();
        //判断请求是否成功
        if (urlConn.getResponseCode() == 200){
            //获取返回数据

            data = readStream(urlConn.getInputStream());

            Log.i("haha", "Get方式请求成功，返回数据如下：");
            m =  new String(data, "UTF-8");
            num=m.split(" ");
            num1=num[3].split(">");
            num2=num1[1].split("<");
            num3=num2[0];

            Log.i("haha", new String(data, "UTF-8"));



        } else {
            Log.i("haha", "Get方式请求失败");

        }
        // 关闭连接
        urlConn.disconnect();

        return data;

    }

    // Get方式请求
    public static  byte[] requestBYGetmes()throws  Exception{
        String path="http://xdssgj.cn/gbook/messageBoard.asmx/queryMessage?queryID="+num3+"";
        Log.i("haha",num3);
        byte[] data = null;
        // 新建一个URL对象=
        URL url=new URL(path);
        // 打开一个HttpURLConnection连接
        HttpURLConnection urlConn = (HttpURLConnection) url.openConnection();
        // 设置连接超时时间
        urlConn.setConnectTimeout(5000);
        //开始连接
        urlConn.connect();
        //判断请求是否成功
        if (urlConn.getResponseCode() == 200){
            //简析xml
            XmlPullParser parser = Xml.newPullParser(); //由android.util.Xml创建一个XmlPullParser实例
            parser.setInput(urlConn.getInputStream(), "UTF-8");
            //设置输入流 并指明编码方式

            int eventType = parser.getEventType();
            while (eventType != XmlPullParser.END_DOCUMENT) {
                switch (eventType) {
                    case XmlPullParser.START_TAG:
                        if (parser.getName().equals("string")) {
                            eventType = parser.next();
                            //简析json
                            JSONObject json = new JSONObject(parser.getText());
                            str6 = json.getString("Title");
                            str7 = json.getString("Contents");
                            str8 = json.getString("M_user");
                            str9 = json.getString("phone");
                            str10 = json.getString("email");
                            str11= json.getString("Rey_contents");
                      }
                        break;
                    case XmlPullParser.END_TAG:

                        break;
                }
                eventType = parser.next();
            }


        } else {
            Log.i("haha", "Get方式请求失败");
        }
        // 关闭连接
        urlConn.disconnect();

        return data;

    }


    private  void showNormalDialog(){
        /* @setIcon 设置对话框图标
         * @setTitle 设置对话框标题
         * @setMessage 设置对话框消息提示
         * setXXX方法返回Dialog对象，因此可以链式设置属性
         */
        final AlertDialog.Builder normalDialog =
                new AlertDialog.Builder(GetAddActivity.this);
        normalDialog.setIcon(R.mipmap.ic_launcher);
        normalDialog.setTitle("速达实时公交");
        normalDialog.setMessage("确定提交？");
        normalDialog.setPositiveButton("确定",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        showDialog();

                    }
                });
        normalDialog.setNegativeButton("关闭",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                    }
                });
        // 显示
        normalDialog.show();
    }
    private  void showDialog(){
        /* @setIcon 设置对话框图标
         * @setTitle 设置对话框标题
         * @setMessage 设置对话框消息提示
         * setXXX方法返回Dialog对象，因此可以链式设置属性
         */
        final AlertDialog.Builder normalDialog =
                new AlertDialog.Builder(GetAddActivity.this);
        normalDialog.setIcon(R.mipmap.ic_launcher);
        normalDialog.setTitle("速达实时公交");
        normalDialog.setMessage("提交成功\n查询码:"+num3);
        normalDialog.setPositiveButton("确定",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        biaoti.setText("");
                        neirong.setText("");
                        name.setText("");
                        phone.setText("");
                        email.setText("");
                    }
                });
        normalDialog.setNegativeButton("关闭",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        //...To-do
                        biaoti.setText("");
                        neirong.setText("");
                        name.setText("");
                        phone.setText("");
                        email.setText("");
                    }
                });
        // 显示
        normalDialog.show();
    }
    private  void showDialog3(){
        /* @setIcon 设置对话框图标
         * @setTitle 设置对话框标题
         * @setMessage 设置对话框消息提示
         * setXXX方法返回Dialog对象，因此可以链式设置属性
         */
        final AlertDialog.Builder normalDialog =
                new AlertDialog.Builder(GetAddActivity.this);
        normalDialog.setIcon(R.mipmap.ic_launcher);
        normalDialog.setTitle("速达实时公交");
        normalDialog.setMessage("正在查询");
        normalDialog.setPositiveButton("确定",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                    }
                });
        normalDialog.setNegativeButton("关闭",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        //...To-do

                    }
                });
        // 显示
        normalDialog.show();
    }
    private  void showDialog2(){
        /* @setIcon 设置对话框图标
         * @setTitle 设置对话框标题
         * @setMessage 设置对话框消息提示
         * setXXX方法返回Dialog对象，因此可以链式设置属性
         */
        final AlertDialog.Builder normalDialog =
                new AlertDialog.Builder(GetAddActivity.this);
        normalDialog.setIcon(R.mipmap.ic_launcher);
        normalDialog.setTitle("速达实时公交");
        normalDialog.setMessage("还没有回复");
        normalDialog.setPositiveButton("确定",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        biaoti.setText("");
                        neirong.setText("");
                        name.setText("");
                        phone.setText("");
                        email.setText("");
                    }
                });
        normalDialog.setNegativeButton("关闭",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        //...To-do
//                        biaoti.setText("");
//                        neirong.setText("");
//                        name.setText("");
//                        phone.setText("");
//                        email.setText("");
                    }
                });
        // 显示
        normalDialog.show();
    }

    private  void showtishiDialog(){
        /* @setIcon 设置对话框图标
         * @setTitle 设置对话框标题
         * @setMessage 设置对话框消息提示
         * setXXX方法返回Dialog对象，因此可以链式设置属性
         */
        final AlertDialog.Builder normalDialog =
                new AlertDialog.Builder(GetAddActivity.this);
        normalDialog.setIcon(R.mipmap.ic_launcher);
        normalDialog.setTitle("速达实时公交");
        normalDialog.setMessage("请输入编码");
        normalDialog.setPositiveButton("确定",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        biaoti.setText("");
                        neirong.setText("");
                        name.setText("");
                        phone.setText("");
                        email.setText("");
                        huifu.setText("");


                    }
                });
        normalDialog.setNegativeButton("关闭",
                new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        //...To-do

                    }
                });
        // 显示
        normalDialog.show();
    }

    // 获取连接返回的数据
    private static byte[] readStream(InputStream inputStream) throws Exception {
        byte[] buffer = new byte[1024];
        int len = -1;
        ByteArrayOutputStream baos = new ByteArrayOutputStream();
        while ((len = inputStream.read(buffer)) != -1) {
            baos.write(buffer, 0, len);
        }
        byte[] data = baos.toByteArray();
        inputStream.close();
        baos.close();
        return data;
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.tijiao:
                try{
                    str1=biaoti.getText().toString();
                   str1= URLEncoder.encode(str1,"UTF-8");
//                    Log.i("jskdfj",str1);
                    str2=neirong .getText().toString();
                    str2=  URLEncoder.encode(str2,"UTF-8");
                    str3=name.getText().toString();
                    str3=  URLEncoder.encode(str3,"UTF-8");
                    str4=phone.getText().toString();
                    str4= URLEncoder.encode(str4,"UTF-8");
                    str5=email.getText().toString();
                    str5= URLEncoder.encode(str5,"UTF-8");
                }catch (Exception   e){

                    e.printStackTrace();
                }



            if (!TextUtils.isEmpty(str1)&&!TextUtils.isEmpty(str2)&&!TextUtils.isEmpty(str3)&&!TextUtils.isEmpty(str4)&&!TextUtils.isEmpty(str5)){

                // 启动一个新线程的代码：
                new Thread(){
                    @Override
                    public void run() {
                        try {
                            s = requestBYGet();


                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    }
                }.start();

                showNormalDialog();

            }else {
                Toast.makeText(this,"请填写必填数据",Toast.LENGTH_LONG).show();

            }
                break;
            case R.id.chaxun:
                num3 = bianma.getText().toString();
                Log.i("sahflkjas ",num3);
                if(TextUtils.isEmpty(num3)){
                    showtishiDialog();
                }else{
                // 启动一个新线程的代码：

                new Thread(){
                    @Override
                    public void run() {
                        try {

                            message=requestBYGetmes();

                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    }
                }.start();


                    biaoti.setText(str6);
                    neirong.setText(str7);
                    name.setText(str8);
                    phone.setText(str9);
                    email.setText(str10);
                    huifu.setText(str11);

                if(TextUtils.isEmpty(str11)){
                    if (a)
                    { showDialog3();
                    a=false;
                    }
                    else{
                    showDialog2();}
                }else{
                    biaoti.setText(str6);
                    neirong.setText(str7);
                    name.setText(str8);
                    phone.setText(str9);
                    email.setText(str10);
                    huifu.setText(str11);
                    }
                }

                break;
//                Intent intentTosug = new Intent(this, get_querymessage.class);
//                startActivity(intentTosug);//从前者跳到后者，特别注意的是，在fragment中，用this来获取当前的activity
            case R.id.tousufanhui:
                finish();
                break;
        }

    }

    @Override
    public void onCheckedChanged(RadioGroup arg0, int arg1) {
        //获取变更后的选中项的ID
        int radioButtonId = arg0.getCheckedRadioButtonId();
        //根据ID获取RadioButton的实例
        RadioButton rb = (RadioButton)GetAddActivity.this.findViewById(radioButtonId);
        //更新文本内容，以符合选中项
        if(rb.getText().toString().equals("男")){
            xingbie = 1 + "";
        }else
        {
            xingbie = 2+"";
        }
    }


}
