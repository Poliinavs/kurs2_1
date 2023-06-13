.586
.model flat,stdcall

includelib kernel32.lib
ExitProcess			PROTO:DWORD
getmin				PROTO:DWORD,:DWORD
getmax				PROTO:DWORD,:DWORD

.stack 4096
.const
.data
.code
;<-------------------------------min------------------------------->
	getmin PROC uses ESI ECX, ptrArray:DWORD,arrLength:DWORD
		
		mov ecx,arrLength
		mov esi,ptrArray
		mov eax,2147483647
		CYCLE:
			cmp eax,[esi]
			jg min
		RETURN:
			add esi,4
		loop CYCLE
		ret
		min:
			mov eax,[esi]
			jmp RETURN
	getmin ENDP

;<-------------------------------max------------------------------->
	getmax PROC uses ESI ECX ,ptrArray:DWORD,arrLength:DWORD
	
		mov ecx,arrLength
		mov esi,ptrArray
		mov eax,-2147483648
		CYCLE:
			cmp eax,[esi]
			jl max
		RETURN:
			add esi,4
		loop CYCLE
		ret
		max:
			mov eax,[esi]
			jmp RETURN
	getmax ENDP
end 
