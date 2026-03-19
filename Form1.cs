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
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                lst_messages.Items.Add(typed_msg);
            }
            // 텍스트 박스 초기화 및 포커스 설정
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter 키로도 메시지를 전송할 수 있도록 처리
            if (e.KeyCode == Keys.Enter)
            {
                btn_send_Click(sender, e);
            }
        }
    }
}
