namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public TextBox txtInput;
        public ListBox lstMessages;
        public Label lblMsgCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // 텍스트 박스와 리스트 박스 하단 레이블 가져오기
            txtInput = txt_input;
            lstMessages = lst_messages;
            lblMsgCount = lbl_msgCount;
            // 텍스트 박스에서 입력한 메시지 가져오기 및 앞 뒤 공백 제거
            String typed_msg = txtInput.Text.Trim();
            // 가져온 메시지를 리스트 박스에 추가
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                // 메시지에 타임스탬프 추가
                lst_messages.Items.Add($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] : {typed_msg}"); 
            }
            // 리스트 박스에 추가된 메시지 개수를 레이블에 표시
            lblMsgCount.Text = $"현재 대화: {lstMessages.Items.Count}개";
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
