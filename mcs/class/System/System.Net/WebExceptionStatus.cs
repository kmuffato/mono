// System.Net.WebExceptionStatus.cs
//
// Author:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//   originally autogenerated by Sergey Chaban (serge@wildwestsoftware.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com

namespace System.Net 
{
	public enum WebExceptionStatus 
	{
		Success = 0,
		NameResolutionFailure = 1,
		ConnectFailure = 2,
		ReceiveFailure = 3,
		SendFailure = 4,
		PipelineFailure = 5,
		RequestCanceled = 6,
		ProtocolError = 7,
		ConnectionClosed = 8,
		TrustFailure = 9,
		SecureChannelFailure = 10,
		ServerProtocolViolation = 11,
		KeepAliveFailure = 12,
		Pending = 13,
		Timeout = 14,
		ProxyNameResolutionFailure = 15,

#if NET_1_1
		UnknownError = 16,
		MessageLengthLimitExceeded = 17,
#endif

	}
}
