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

            // 폼이 생성될 때 컨트롤들을 한 번만 전역 변수에 할당
            txtInput = txt_input;
            lstMessages = lst_messages;
            lblMsgCount = lbl_msgCount;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에서 입력한 메시지 가져오기 및 앞 뒤 공백 제거
            String typed_msg = txtInput.Text.Trim();
            // 가져온 메시지를 리스트 박스에 추가
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                // 메시지 길이 제한 (50자 이내)
                if (typed_msg.Length <= 50)
                {
                    // 메시지에 타임스탬프 추가
                    lstMessages.Items.Add($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] : {typed_msg}");
                }
                else
                {
                    // 메시지가 50자를 초과하는 경우 경고 메시지 표시
                    MessageBox.Show("메시지는 50자 이내로 입력해주세요.", "메시지 길이 초과", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            // 리스트 박스에 추가된 메시지 개수를 레이블에 표시
            updateMessageCount();
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

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            // 선택된 메시지의 인덱스 가져오기
            int selectedIndex = lstMessages.SelectedIndex;
            // 선택된 메시지가 있는 경우 해당 메시지 삭제
            if (selectedIndex > -1)
            {
                lstMessages.Items.RemoveAt(selectedIndex);
                // 메시지 삭제 후 개수 업데이트
                updateMessageCount();

            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            // 모든 메시지 삭제
            lstMessages.Items.Clear();
            // 메시지 삭제 후 개수 업데이트
            updateMessageCount();
        }

        private void updateMessageCount()
        {
            lblMsgCount.Text = $"현재 대화: {lstMessages.Items.Count}개";
        }
    }
}
