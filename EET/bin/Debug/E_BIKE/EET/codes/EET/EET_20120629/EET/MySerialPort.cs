using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace EET
{
    class MySerialPort
    {
        ///// <summary>
        ///// ������һ��ί������
        ///// </summary>
        //public delegate void WhenGetNew();

        ///// <summary>
        ///// ���ڷ�װ�࣬Help By Wyz
        ///// </summary>
        //public class PortDataDisplay
        //{
        //    /// <summary>
        //    /// ϵͳ������
        //    /// </summary>
        //    public SerialPort serialPort = new SerialPort("COM1", 9600);
        //    /// <summary>
        //    /// �����õ����ݺ󴥷��¼�
        //    /// </summary>
        //    public event WhenGetNew whenGetNew;
        //    /// <summary>
        //    /// �����߳�
        //    /// </summary>
        //    private SerialDataReceivedEventHandler threadCallHandler;
        //    /// <summary>
        //    /// ������������Ͷ���
        //    /// </summary>
        //    public string dataSrc = "";
        //    /// <summary>
        //    /// ׼���رմ���=true
        //    /// </summary>
        //    private bool m_IsTryToClosePort = false;
        //    /// <summary>
        //    /// true��ʾ���ڽ�������
        //    /// </summary>
        //    private bool m_IsReceiving = false;


        //    /// <summary>
        //    /// ��ʼ��
        //    /// </summary>
        //    public PortDataDisplay()
        //    {
        //    }

        //    /// <summary>
        //    /// �в����Ĺ��캯��
        //    /// </summary>
        //    /// <param name="PortName">���ںţ���"COM1"</param>
        //    /// <param name="BaudRate">�����ʣ���9600</param>
        //    public PortDataDisplay(string PortName, int BaudRate)
        //    {
        //        serialPort = new SerialPort(PortName, BaudRate);
        //    }

        //    /// <summary>
        //    /// ��ʼ����
        //    /// </summary>
        //    public void ConnectDeveice()
        //    {
        //        //0.ע���¼�
        //        serialPort.DataReceived -= OnSerialPortDataCome;
        //        serialPort.DataReceived += OnSerialPortDataCome;
        //        //1.������һ�´��ڲ���
        //        if (this.serialPort.IsOpen == false)
        //        {
        //            this.serialPort.ReadBufferSize = 1000;
        //            this.serialPort.ReceivedBytesThreshold = 1;//���ݴﵽ120��ʱ��ž�Ҫ�����¼������У���Ӧ�����������ʹ���
        //            //2.�򿪴��ڿ�ʼ����
        //            m_IsTryToClosePort = false;
        //            this.serialPort.Open();
        //        }
        //    }

        //    /// <summary>
        //    /// ��������
        //    /// </summary>
        //    public void DisconnectDeveice() // �ؼ��ͺ��ģ�����
        //    {
        //        m_IsTryToClosePort = true;
        //        while (m_IsReceiving)
        //        {
        //            System.Windows.Forms.Application.DoEvents();
        //        }
        //        serialPort.Close();
        //    }

        //    /// <summary>
        //    /// ��֪ͨ�������ݴﵽ120ʱ������ȡ���������
        //    /// </summary>
        //    /// <param name="sender"></param>
        //    /// <param name="e"></param>
        //    private void OnSerialPortDataCome(object sender, SerialDataReceivedEventArgs e)
        //    {
        //        if (m_IsTryToClosePort) // �ؼ�������
        //        {
        //            return;
        //        }

        //        m_IsReceiving = true; // �ؼ�!!!

        //        try
        //        {
        //            if (threadCallHandler == null)
        //            {
        //                threadCallHandler = new SerialDataReceivedEventHandler(OnSerialPortDataCome);
        //            }

        //            //read
        //            dataSrc = serialPort.ReadExisting();//������������������
        //            if (dataSrc != "" && this.whenGetNew != null)
        //            {
        //                this.whenGetNew();
        //            }
        //        }
        //    finally // ����finally����ȽϺá�
        //        {
        //            m_IsReceiving = false; // �ؼ�!!!
        //        }
        //    }
        //}
    }
}
