using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EET
{
    public partial class HelpFile : Form
    {
        public HelpFile()
        {
            InitializeComponent();
            // ȡ����󻯺���С����ť
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        //���ѡ�нڵ�ĵȼ�
        public int NodeLevel(TreeNode n)
        {
            int i = 0;
            while (!(n.Parent == null))
            {
                n = n.Parent;
                i += 1;
            }
            return i;
        }

        // ����ڵ�鿴�����ĵ�
        private void treeView_List_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox_SelectedNode.Text = e.Node.Text;
            // "\r\n" �س�����
            switch (e.Node.Text)
            {
                case "������":
                    richTextBox_Information.Text = "������������˵����������������� ����״̬������\r\n���Խ������õļ��ء����桢��ȡ�����صȲ�����\r\n��������贮��֧�֣���Ҫ�����Ӵ��ں��ٴ������";
                    break;
                case "�˵���":
                    richTextBox_Information.Text = "�˵������������Ϸ����������ļ������������������˿ڡ� ������������";
                    break;
                case "�ļ�":
                    richTextBox_Information.Text = "�ļ����������ļ��������á������������õ��ļ����������ļ��С������˳���";
                    break;
                case "���ļ���������":
                    richTextBox_Information.Text = "���Ѿ�����������ļ����ص�����У����ڵ��Թ������ÿ��ٵĻָ���";
                    break;
                case "�������õ��ļ�":
                    richTextBox_Information.Text = "���Ѿ����Թ������ñ��浽�����ļ��У������浵���������ļ�Ҳ���Ա��ٴμ��ص�����С�";
                    break;
                case "���ļ���":
                    richTextBox_Information.Text = "�򿪴�������ĵ����ļ��С�";
                    break;
                case "�˳�":
                    richTextBox_Information.Text = "�ر������";
                    break;
                case "����":
                    richTextBox_Information.Text = "�����������ӿ�������ȡ���á������������õ��������������ö�����";
                    break;
                case "�ӿ�������ȡ����":
                    richTextBox_Information.Text = "�ӿ�������ȡ�������ڲ��ĵ�ǰ���ã���ȡ�Ĳ������������ԵĻ���ֵ�����߶�ȡ�󱣴浽�����ĵ��������浵��";
                    break;
                case "�������õ�������":
                    richTextBox_Information.Text = "�������ǰ���������ص��������ڽ��е��ԡ�";
                    break;
                case "�ö�":
                    richTextBox_Information.Text = "������������д��ڵ���ǰ�ˣ������趨����ȡ����";
                    break;
                case "�˿�":
                    richTextBox_Information.Text = "��Ҫʹ�ñ�������������Ӵ��ں��ٴ򿪱���������õĶ˿ںŻ��Զ����ص��б��У�ѡ���Ӧ�Ķ˿ں���Խ���ͨѶ��";
                    break;
                case "����":
                    richTextBox_Information.Text = "�����������ĵ����������ڡ�";
                    break;
                case "�����ĵ�":
                    richTextBox_Information.Text = "�����ĵ���";
                    break;
                case "����":
                    richTextBox_Information.Text = "����汾������Ȩ˵����";
                    break;
                case "״̬��":
                    richTextBox_Information.Text = "״̬�����������·���״̬����ʾ��������ѡ��Ĵ��ڶ˿ںţ����ڵ�ǰ״̬��ͨѶ����״̬����������";
                    break;
                case "��ʾ��":
                    richTextBox_Information.Text = "����ʾ�ӿ������ڲ���ȡ�������Ϣ���������ڵ������޷����ġ�";
                    break;
                case "����汾��":
                    richTextBox_Information.Text = "��ȡ������汾�š�";
                    break;
                case "Ӳ���汾��":
                    richTextBox_Information.Text = "��ȡ��Ӳ���汾�š�";
                    break;
                case "��Ʒ�ͺ�":
                    richTextBox_Information.Text = "��ȡ�Ĳ�Ʒ�ͺ�";
                    break;
                case "�������":
                    richTextBox_Information.Text = "��ȡ�Ŀ�������Ӧ����ļ���";
                    break;
                case "��������":
                    richTextBox_Information.Text = "��ȡ�Ĺ���������";
                    break;
                case "�����������¶�":
                    richTextBox_Information.Text = "��ȡ�Ŀ����������¶�";
                    break;
                case "�����趨��":
                    richTextBox_Information.Text = "���ò���ֵ��";
                    break;
                case "�������":
                    richTextBox_Information.Text = "���õ������\r\n���������С�\r\n���������С���";
                    break;
                case "��ض��ѹ":
                    richTextBox_Information.Text = "���õ�ǰʹ�õĵ�ض��ѹ��";
                    break;
                case "��ر�����ѹ ��ѹ":
                    richTextBox_Information.Text = "����ѡ��ĵ�ض��ѹֵ�����õ�ر�����ѹ ��ѹֵ\r\n48V��ص����÷�ΧΪ��48��56V��\r\n36V��ص����÷�ΧΪ��36��42V����";
                    break;
                case "��ر�����ѹ Ƿѹ":
                    richTextBox_Information.Text = "����ѡ��ĵ�ض��ѹֵ�����õ�ر�����ѹ Ƿѹֵ\r\n48V��ص����÷�ΧΪ��42��48V��\r\n36V��ص����÷�ΧΪ��28��36V����";
                    break;
                case "����":
                    richTextBox_Information.Text = "��ʾ����\r\n���С�\r\n���ޡ���";
                    break;
                case "���ɳ�������ѹ ����":
                    richTextBox_Information.Text = "���÷��ɳ�������ѹ ����ֵ\r\n���÷�ΧΪ��2.1��4.9V����";
                    break;
                case "���ɳ�������ѹ ����":
                    richTextBox_Information.Text = "���÷��ɳ�������ѹ ����ֵ\r\n���÷�ΧΪ��0.1��1.9V����";
                    break;
                case "�������":
                    richTextBox_Information.Text = "���û������\r\n��60��\r\n��120����";
                    break;
                case "�������ֵ����":
                    richTextBox_Information.Text = "�����������ֵ����ֵ\r\n���÷�ΧΪ��6��35A����";
                    break;
                case "�ֱ����ٵ�ѹ ����":
                    richTextBox_Information.Text = "�����ֱ����ٵ�ѹ ����ֵ\r\n���÷�ΧΪ��2.1��4.9V����";
                    break;
                case "�ֱ����ٵ�ѹ ����":
                    richTextBox_Information.Text = "�����ֱ����ٵ�ѹ ����ֵ\r\n���÷�ΧΪ��0.1��1.9V����";
                    break;
                case "��ת��������":
                    richTextBox_Information.Text = "���ö�ת��������ֵ\r\n���÷�ΧΪ��6��40A����";
                    break;
                case "����ѡ����":
                    richTextBox_Information.Text = "���ù���ֵ��ÿ��ǰ�ĸ�ѡ������ѡ����ʹ�������ʾ�ı궨ֵ��������ģ����ȹ�ѡ��ѡ��Ȼ���ٸ�����ز�����";
                    break;
                case "��������":
                    richTextBox_Information.Text = "�����������á�";
                    break;
                case "�Ͽ�������":
                    richTextBox_Information.Text = "���Ͽ�������ʱ\r\n��������ֵ��ΧΪ��1��600RPM��\r\n��������ֵ��ΧΪ��1��35A����";
                    break;
                case "����������":
                    richTextBox_Information.Text = "������������ʱ\r\n��������ֵ��ΧΪ��1��600RPM��\r\n��������ֵ��ΧΪ��1��35A����";
                    break;
                case "������ʽ":
                    richTextBox_Information.Text = "������ʽ��ѡ����������1����Ӳ������10����10����λ������ݵ�������������á�";
                    break;
                case "Ѳ������":
                    richTextBox_Information.Text = "����Ѳ������\r\n���ޡ�\r\n���ֶ���\r\n���Զ���\r\n���Զ���ѡ�񡱡�";
                    break;
                case "�Զ�Ѳ���ֱ��ȶ�ʱ��":
                    richTextBox_Information.Text = "�����Զ�Ѳ���ֱ��ȶ�ʱ��ֵ\r\n���÷�ΧΪ��2��12S����";
                    break;
                case "�ֶ�Ѳ����������ʱ��":
                    richTextBox_Information.Text = "�����ֶ�Ѳ����������ʱ��ֵ\r\n���÷�ΧΪ��0.1��4S����";
                    break;
                case "��������":
                    richTextBox_Information.Text = "������������\r\n���ޡ�\r\n���ֶ���\r\n���Զ�����";
                    break;
                case "�綯Ѳ������ת��":
                    richTextBox_Information.Text = "���õ綯Ѳ������ת��\r\n���ޡ�\r\n���綯��Ѳ����������\r\n���綯��������Ѳ������";
                    break;
                case "��ת��������":
                    richTextBox_Information.Text = "���ö�ת��������\r\n��3�����ȫ��������\r\n��3���ڷֽ׶ν���������";
                    break;
                case "����ɲ���ɳ�":
                    richTextBox_Information.Text = "��������ɲ���ɳ�\r\n���ޡ�\r\n���С���";
                    break;
                case "ɲ������":
                    richTextBox_Information.Text = "����ɲ������\r\n���ޡ�\r\n�������ء�\r\n����ʸ����\r\n��ֱ����������";
                    break;
                case "ɲ������":
                    richTextBox_Information.Text = "ɲ�����ȵ�ѡ����10����λ������ݵ�������������á�";
                    break;
                case "����ͺ�":
                    richTextBox_Information.Text = "���ò�ͬ����ͺ�\r\n���÷�ΧΪ��0��255��.";
                    break;
                case "ģ���ٶ���ʾ���ֵ":
                    richTextBox_Information.Text = "�趨ģ���ٶ���ʾ���ֵ��ģ���ٶ���ʾ�ٶȵ�ѹ��Ӧ��ϵ\r\n���÷�ΧΪ��0.2��1����";
                    break;
                case "ģ�������ʾ���ֵ":
                    richTextBox_Information.Text = "�趨ģ�������ʾ���ֵ��ģ�������ʾ������ѹ��Ӧ��ϵ\r\n���÷�ΧΪ��2��10����";
                    break;
                case "��̬��ʾ":
                    richTextBox_Information.Text = "������̬��ʾ\r\n���ޡ�\r\n���綯��Ѳ��������(�ߵ�ƽ�����裭�͵�ƽ)��\r\n���綯��Ѳ��������(�ߵ�ƽ���͵�ƽ������)��\r\n���綯��Ѳ��������(���裭�ߵ�ƽ���͵�ƽ)��\r\n���綯��Ѳ��������(���裭�͵�ƽ���ߵ�ƽ)��\r\n���綯��Ѳ��������(�͵�ƽ�����裭�ߵ�ƽ)��\r\n���綯��Ѳ��������(�͵�ƽ���ߵ�ƽ������)����";
                    break;
                case "���з����":
                    richTextBox_Information.Text = "���û��з���磬���ޡ����ߡ��С���";
                    break;
                case "����ʵ��":
                    richTextBox_Information.Text = "���ö���ʵ��\r\n���ޡ�\r\n�������л���ʽ(����е�����)��\r\n�������л���ʽ(���е�����)��\r\n�������л���ʽ(�ߵ�����)��\r\n��2������(�ߵ����ٿ�ѡ)��\r\n��3������(���е����ٿ�ѡ)��\r\n��4������(���١��ߡ��С������ٿ�ѡ)����";
                    break;
                default:
                    break;
            }
        }
    }
}