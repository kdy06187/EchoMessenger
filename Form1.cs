namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public TextBox txtInput;
        public ListBox lstMessages;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // 텍스트 박스와 리스트 박스 가져오기
            txtInput = txt_input;
            lstMessages = lst_messages;
            // 텍스트 박스에서 입력한 메시지 가져오기
            String typed_msg = txtInput.Text;
            // 가져온 메시지를 리스트 박스에 추가
            lst_messages.Items.Add(typed_msg);
            // 텍스트 박스 초기화
            txtInput.Text = "";
        }
    }
}
