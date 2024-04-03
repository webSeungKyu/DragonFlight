# DragonFlight
 드래곤플라이트 만들기



https://github.com/webSeungKyu/DragonFlight/assets/112837427/1c310b72-4fa2-478a-992f-e9c5df46bcb5


1945 게임 로직 이해를 위하여 최소한의 형태만 구현함

 

※ 새로 배운 것

[함수]
자동 생성 시 : InvokeRepeating 

 - InvokeRepeating ( 반복 실행할 함수, 첫 지연 시간, 이후의 지연 시간 )

 

 

카메라 밖으로 이동 시 삭제 함수 : OnBecameInvisible

 - 보고 있는 화면 밖으로 나가면 안 보일경우 호출됨 (Ctrl + Shift + M) 눌러서 찾을 수도 있음

 




[배경]

3D 배경 Quad - Material 배경(BackGround) 생성하여 입히기 - 자동 스크롤(mainTextureOffset)
