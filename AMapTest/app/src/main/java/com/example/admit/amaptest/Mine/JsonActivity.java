package com.example.admit.amaptest.Mine;


import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Window;


import com.example.admit.amaptest.R;

import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;


public class JsonActivity extends AppCompatActivity {
    private byte[]s = null;
    private static String m;

    private static String[] BuslineStationIDlist;
    private static String[] xmllist;
    private  static String[] stopno;
    private static String[]sno1;
    private static double sno2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        this.supportRequestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_liuyan);
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
    }
    // Get方式请求
    public static  byte[] requestBYGet()throws  Exception{
        String path="http://xdssgj.cn/service/busposition.asmx/busNowPosition?lineID=140100010330&stationName=赵庄";
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
            BuslineStationIDlist=m.split(",");
           xmllist=BuslineStationIDlist[9].split(":");
            stopno=xmllist[1].split("]");
            sno1= stopno[0].split("");
            sno2 = new Integer(sno1[1]) ;
            Log.i("haha", new String(data, "UTF-8"));
        } else {
            Log.i("haha", "Get方式请求失败");

        }
        // 关闭连接
        urlConn.disconnect();

        return data;

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



}
