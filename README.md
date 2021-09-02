# [C#]Winform을 사용한 IR serial write tool

1. 기본동작 메커니즘 : 

      port 지정된 Cypress사 의 MCU 와 UART communicate

      -> Serial write

      -> Cypress ppcli.exe 사용

      -> Kit Number 일치 확인

      -> ppcli가 열리면 활성화 키매크로 cmd로 config tab의 내용 전달



사용시 주의사항

1. Kit Number 확인 (KitList)
2. Serial Number Write 확인
3. "C:\Program Files (x86)\IR_SerialWrite" 혹은 사용자 지정 폴더에 ppcli.exe 파일 확인
4. config (수정 가능 + 더블클릭시 가져오기가능)
5. serialWrite