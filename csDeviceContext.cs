// Namespace: Takasho
public sealed class DeviceContext : IDisposable // TypeDefIndex: 2273
{
	// Fields
	private bool disposed; // 0x10
	[CompilerGenerated]
	private string <Account>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Password>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <PlayerId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <SessionToken>k__BackingField; // 0x30
	private static string storedDirectory; // 0x0
	public const string StoredFileName = "dc.bin";
	private static readonly char[] randomChars; // 0x8
	private const int RandomStringsLength = 32;
	private static DeviceContext storedDeviceContext; // 0x10
	private static byte[] k; // 0x18
	private static DeviceContext mainDeviceContext; // 0x20

	// Properties
	public string Account { get; set; }
	public string Password { get; set; }
	public string PlayerId { get; set; }
	public string SessionToken { get; set; }
	public static string StoredDirectory { get; set; }
	public static DeviceContext StoredDeviceContext { get; set; }
	public static DeviceContext MainDeviceContext { get; set; }

	// Methods

	// RVA: 0x5136E30 Offset: 0x5132E30 VA: 0x5136E30
	public void .ctor(string account, string password) { }

	// RVA: 0x5136E74 Offset: 0x5132E74 VA: 0x5136E74 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x5137028 Offset: 0x5133028 VA: 0x5137028 Slot: 4
	public void Dispose() { }

	[CompilerGenerated]
	// RVA: 0x51371A8 Offset: 0x51331A8 VA: 0x51371A8
	public string get_Account() { }

	[CompilerGenerated]
	// RVA: 0x51371B0 Offset: 0x51331B0 VA: 0x51371B0
	private void set_Account(string value) { }

	[CompilerGenerated]
	// RVA: 0x51371B8 Offset: 0x51331B8 VA: 0x51371B8
	public string get_Password() { }

	[CompilerGenerated]
	// RVA: 0x51371C0 Offset: 0x51331C0 VA: 0x51371C0
	private void set_Password(string value) { }

	[CompilerGenerated]
	// RVA: 0x51371C8 Offset: 0x51331C8 VA: 0x51371C8
	public string get_PlayerId() { }

	[CompilerGenerated]
	// RVA: 0x51371D0 Offset: 0x51331D0 VA: 0x51371D0
	private void set_PlayerId(string value) { }

	[CompilerGenerated]
	// RVA: 0x51371D8 Offset: 0x51331D8 VA: 0x51371D8
	public string get_SessionToken() { }

	[CompilerGenerated]
	// RVA: 0x51371E0 Offset: 0x51331E0 VA: 0x51371E0
	private void set_SessionToken(string value) { }

	// RVA: 0x51371E8 Offset: 0x51331E8 VA: 0x51371E8
	public static string get_StoredDirectory() { }

	// RVA: 0x513743C Offset: 0x513343C VA: 0x513743C
	public static void set_StoredDirectory(string value) { }

	// RVA: 0x513756C Offset: 0x513356C VA: 0x513756C
	private static string GenerateRandomStrings() { }

	// RVA: 0x5137A3C Offset: 0x5133A3C VA: 0x5137A3C
	private static void .cctor() { }

	// RVA: 0x5138164 Offset: 0x5134164 VA: 0x5138164
	public static DeviceContext get_StoredDeviceContext() { }

	// RVA: 0x5139100 Offset: 0x5135100 VA: 0x5139100
	public static void set_StoredDeviceContext(DeviceContext value) { }

	// RVA: 0x5138FD4 Offset: 0x5134FD4 VA: 0x5138FD4
	public static DeviceContext CreateNewDeviceContext() { }

	// RVA: 0x5139D58 Offset: 0x5135D58 VA: 0x5139D58
	public static DeviceContext get_MainDeviceContext() { }

	// RVA: 0x5139FDC Offset: 0x5135FDC VA: 0x5139FDC
	public static void set_MainDeviceContext(DeviceContext value) { }

	// RVA: 0x513A104 Offset: 0x5136104 VA: 0x513A104
	public void Update(string playerId, string sessionToken) { }

	// RVA: 0x513A134 Offset: 0x5136134 VA: 0x513A134
	public void Store() { }
}

// Namespace: Takasho
public interface IAuthorizer // TypeDefIndex: 2285
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsNeedAuthorize(ErrorCode errorCode);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<AuthorizeResult> Authorize(DeviceContext deviceContext);
}

// Namespace: 
[CompilerGenerated]
private struct Requester.<SendAsync>d__5<PReq, PRes> : IAsyncStateMachine // TypeDefIndex: 2286
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<APIResult<PRes>> <>t__builder; // 0x0
	public Requester<PReq, PRes> <>4__this; // 0x0
	public PReq body; // 0x0
	public DeviceContext dc; // 0x0
	public Nullable<RequestOptions> requestOptions; // 0x0
	private object <clientState>5__2; // 0x0
	private Nullable<long> <requestedTimestamp>5__3; // 0x0
	private Nullable<long> <respondTimestamp>5__4; // 0x0
	private Nullable<long> <adjustedTimestamp>5__5; // 0x0
	private string <requestId>5__6; // 0x0
	private Connection <connection>5__7; // 0x0
	private Connection.KeepAliveHandle <keepAliveHandle>5__8; // 0x0
	private ResponseMetadataSet <responseMetadataSet>5__9; // 0x0
	private AsyncUnaryCall<PRes> <asyncUnaryCall>5__10; // 0x0
	[Nullable(new[] { 0, 1 })]
	private TaskAwaiter<Metadata> <>u__1; // 0x0
	private TaskAwaiter<PRes> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F35114 Offset: 0x2F31114 VA: 0x2F35114
	|-Requester.<SendAsync>d__5<object, object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F363A8 Offset: 0x2F323A8 VA: 0x2F363A8
	|-Requester.<SendAsync>d__5<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct Requester.<SendWithAuthorizeAsync>d__4<PReq, PRes> : IAsyncStateMachine // TypeDefIndex: 2287
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<APIResult<PRes>> <>t__builder; // 0x0
	public Requester<PReq, PRes> <>4__this; // 0x0
	public DeviceContext dc; // 0x0
	public PReq body; // 0x0
	public Nullable<RequestOptions> requestOptions; // 0x0
	private TaskAwaiter<APIResult<PRes>> <>u__1; // 0x0
	private TaskAwaiter<AuthorizeResult> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F3642C Offset: 0x2F3242C VA: 0x2F3642C
	|-Requester.<SendWithAuthorizeAsync>d__4<object, object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F36ED8 Offset: 0x2F32ED8 VA: 0x2F36ED8
	|-Requester.<SendWithAuthorizeAsync>d__4<object, object>.SetStateMachine
	*/
}

// Namespace: Takasho
public abstract class Requester<PReq, PRes> // TypeDefIndex: 2288
{
	// Properties
	protected abstract string EndpointId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string get_EndpointId();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract AsyncUnaryCall<PRes> SendGrpcRequest(PReq body, CallInvoker callInvoker, Metadata headers, Nullable<DateTime> deadline);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract ErrorCode ParseErrorCode(int errorCode);

	[AsyncStateMachine(typeof(Requester.<SendWithAuthorizeAsync>d__4<PReq, PRes>))]
	// RVA: -1 Offset: -1
	public Task<APIResult<PRes>> SendWithAuthorizeAsync(DeviceContext dc, PReq body, Nullable<RequestOptions> requestOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E34228 Offset: 0x2E30228 VA: 0x2E34228
	|-Requester<object, object>.SendWithAuthorizeAsync
	*/

	[AsyncStateMachine(typeof(Requester.<SendAsync>d__5<PReq, PRes>))]
	// RVA: -1 Offset: -1
	public Task<APIResult<PRes>> SendAsync(DeviceContext dc, PReq body, Nullable<RequestOptions> requestOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3443C Offset: 0x2E3043C VA: 0x2E3443C
	|-Requester<object, object>.SendAsync
	*/

	// RVA: -1 Offset: -1
	private static Nullable<long> ParseResponseTrailers(AsyncUnaryCall<PRes> asyncUnaryCall, ResponseMetadataSet responseMetadataSet, ref Nullable<long> respondTimestamp, Connection connection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E34650 Offset: 0x2E30650 VA: 0x2E34650
	|-Requester<object, object>.ParseResponseTrailers
	*/

	// RVA: -1 Offset: -1
	private void ParseResponseHeaders(Metadata responseHeaders, ResponseMetadataSet responseMetadataSet, ref Nullable<long> requestedTimestamp, ref Nullable<long> adjustedTimestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E358B8 Offset: 0x2E318B8 VA: 0x2E358B8
	|-Requester<object, object>.ParseResponseHeaders
	*/

	// RVA: -1 Offset: -1
	private AsyncUnaryCall<PRes> SendAsyncUnaryCall(DeviceContext dc, PReq body, Nullable<RequestOptions> requestOptions, string requestId, CallInvoker invoker, Nullable<int> requestTimeoutMillisSeconds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E368D4 Offset: 0x2E328D4 VA: 0x2E368D4
	|-Requester<object, object>.SendAsyncUnaryCall
	*/

	// RVA: -1 Offset: -1
	private APIResult<PRes> WithRaiseResponseReceived(APIResult<PRes> apiResult, object clientState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E38420 Offset: 0x2E34420 VA: 0x2E38420
	|-Requester<object, object>.WithRaiseResponseReceived
	*/

	// RVA: -1 Offset: -1
	private static bool ContainsInternalException<TException>(Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDB14C Offset: 0x2CD714C VA: 0x2CDB14C
	|-Requester<object, object>.ContainsInternalException<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void ParseAndApplyAdvertises(Metadata.Entry entry, Connection connection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3867C Offset: 0x2E3467C VA: 0x2E3867C
	|-Requester<object, object>.ParseAndApplyAdvertises
	*/

	// RVA: -1 Offset: -1
	public APIResult<PRes> ParseRpcException(RpcException rpcException, string requestId, Nullable<long> requestedTimestamp, Nullable<long> respondTimestamp, Nullable<long> adjustedTimestamp, Connection connection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E38CF8 Offset: 0x2E34CF8 VA: 0x2E38CF8
	|-Requester<object, object>.ParseRpcException
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E3AF14 Offset: 0x2E36F14 VA: 0x2E3AF14
	|-Requester<object, object>..ctor
	*/
}

// Namespace: Takasho
public class InitializeParameter // TypeDefIndex: 2290
{
	// Fields
	[CompilerGenerated]
	private readonly Nullable<int> <ConnectTimeoutMilliSeconds>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Nullable<int> <RequestTimeoutMilliSeconds>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <ServerEndpoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <ServerToken>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly ApplicationVersion <ApplicationVersion>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly ApplicationBuildVersion <ApplicationBuildVersion>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly Platform <Platform>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly string <DeviceModel>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly Os <Os>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly string <OsDetail>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly IAuthorizer <Authorizer>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly string <DeviceContextStoreDirectory>k__BackingField; // 0x68
	[CompilerGenerated]
	private readonly int <KeepAliveTimeMilliSeconds>k__BackingField; // 0x70
	[CompilerGenerated]
	private readonly int <KeepAliveTimeoutMilliSeconds>k__BackingField; // 0x74
	[CompilerGenerated]
	private IGrpcHttpMessageHandlerFactory <HttpMessageHandlerFactory>k__BackingField; // 0x78

	// Properties
	public Nullable<int> ConnectTimeoutMilliSeconds { get; }
	public Nullable<int> RequestTimeoutMilliSeconds { get; }
	public string ServerEndpoint { get; }
	public string ServerToken { get; }
	public ApplicationVersion ApplicationVersion { get; }
	public ApplicationBuildVersion ApplicationBuildVersion { get; }
	public Platform Platform { get; }
	public string DeviceModel { get; }
	public Os Os { get; }
	public string OsDetail { get; }
	public IAuthorizer Authorizer { get; }
	public string DeviceContextStoreDirectory { get; }
	public int KeepAliveTimeMilliSeconds { get; }
	public int KeepAliveTimeoutMilliSeconds { get; }
	public IGrpcHttpMessageHandlerFactory HttpMessageHandlerFactory { get; set; }

	// Methods

	// RVA: 0x513F2A4 Offset: 0x513B2A4 VA: 0x513F2A4
	public void .ctor(string serverEndpoint, string serverToken, ApplicationVersion applicationVersion, ApplicationBuildVersion applicationBuildVersion, Platform platform, string deviceModel, Os os, string osDetail, IAuthorizer authorizer, string deviceContextStoreDirectory, int keepAliveTimeMilliSeconds = 10000, int keepAliveTimeoutMilliSeconds = 20000, Nullable<int> connectTimeoutMilliSeconds, Nullable<int> requestTimeoutMilliSeconds) { }

	[CompilerGenerated]
	// RVA: 0x513F51C Offset: 0x513B51C VA: 0x513F51C
	public Nullable<int> get_ConnectTimeoutMilliSeconds() { }

	[CompilerGenerated]
	// RVA: 0x513F524 Offset: 0x513B524 VA: 0x513F524
	public Nullable<int> get_RequestTimeoutMilliSeconds() { }

	[CompilerGenerated]
	// RVA: 0x513F52C Offset: 0x513B52C VA: 0x513F52C
	public string get_ServerEndpoint() { }

	[CompilerGenerated]
	// RVA: 0x513F534 Offset: 0x513B534 VA: 0x513F534
	public string get_ServerToken() { }

	[CompilerGenerated]
	// RVA: 0x513F53C Offset: 0x513B53C VA: 0x513F53C
	public ApplicationVersion get_ApplicationVersion() { }

	[CompilerGenerated]
	// RVA: 0x513F544 Offset: 0x513B544 VA: 0x513F544
	public ApplicationBuildVersion get_ApplicationBuildVersion() { }

	[CompilerGenerated]
	// RVA: 0x513F54C Offset: 0x513B54C VA: 0x513F54C
	public Platform get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x513F554 Offset: 0x513B554 VA: 0x513F554
	public string get_DeviceModel() { }

	[CompilerGenerated]
	// RVA: 0x513F55C Offset: 0x513B55C VA: 0x513F55C
	public Os get_Os() { }

	[CompilerGenerated]
	// RVA: 0x513F564 Offset: 0x513B564 VA: 0x513F564
	public string get_OsDetail() { }

	[CompilerGenerated]
	// RVA: 0x513F56C Offset: 0x513B56C VA: 0x513F56C
	public IAuthorizer get_Authorizer() { }

	[CompilerGenerated]
	// RVA: 0x513F574 Offset: 0x513B574 VA: 0x513F574
	public string get_DeviceContextStoreDirectory() { }

	[CompilerGenerated]
	// RVA: 0x513F57C Offset: 0x513B57C VA: 0x513F57C
	public int get_KeepAliveTimeMilliSeconds() { }

	[CompilerGenerated]
	// RVA: 0x513F584 Offset: 0x513B584 VA: 0x513F584
	public int get_KeepAliveTimeoutMilliSeconds() { }

	[CompilerGenerated]
	// RVA: 0x513F58C Offset: 0x513B58C VA: 0x513F58C
	public IGrpcHttpMessageHandlerFactory get_HttpMessageHandlerFactory() { }

	[CompilerGenerated]
	// RVA: 0x513F594 Offset: 0x513B594 VA: 0x513F594
	public void set_HttpMessageHandlerFactory(IGrpcHttpMessageHandlerFactory value) { }
}

// Namespace: 
[CompilerGenerated]
private struct System.<Authorize>d__0 : IAsyncStateMachine // TypeDefIndex: 2329
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AuthorizeResult> <>t__builder; // 0x8
	public IAuthorizer authorizer; // 0x20
	public DeviceContext dc; // 0x28
	private TaskAwaiter<AuthorizeResult> <>u__1; // 0x30

	// Methods

	// RVA: 0x5150D48 Offset: 0x514CD48 VA: 0x5150D48 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x5151158 Offset: 0x514D158 VA: 0x5151158 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Takasho
public static class System // TypeDefIndex: 2330
{
	// Methods

	[AsyncStateMachine(typeof(System.<Authorize>d__0))]
	// RVA: 0x5150960 Offset: 0x514C960 VA: 0x5150960
	public static Task<AuthorizeResult> Authorize(DeviceContext dc, IAuthorizer authorizer) { }

	// RVA: 0x5150A8C Offset: 0x514CA8C VA: 0x5150A8C
	public static bool InitializeSystem(InitializeParameter initializeParameter) { }

	// RVA: 0x5150D44 Offset: 0x514CD44 VA: 0x5150D44
	public static void FinalizeSystem() { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Action // TypeDefIndex: 2334
{
	// Methods

	// RVA: 0x51511D4 Offset: 0x514D1D4 VA: 0x51511D4
	public static APIResult<ActionSyncStatesV1.Types.Response> Send(ActionSyncStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151270 Offset: 0x514D270 VA: 0x5151270
	public static Task<APIResult<ActionSyncStatesV1.Types.Response>> SendAsync(ActionSyncStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151364 Offset: 0x514D364 VA: 0x5151364
	public static APIResult<ActionSyncStatesV1.Types.Response> SendWithAuthorize(ActionSyncStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151400 Offset: 0x514D400 VA: 0x5151400
	public static Task<APIResult<ActionSyncStatesV1.Types.Response>> SendWithAuthorizeAsync(ActionSyncStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51514AC Offset: 0x514D4AC VA: 0x51514AC
	public static APIResult<ActionSyncNALinkStateV1.Types.Response> Send(ActionSyncNALinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151548 Offset: 0x514D548 VA: 0x5151548
	public static Task<APIResult<ActionSyncNALinkStateV1.Types.Response>> SendAsync(ActionSyncNALinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515163C Offset: 0x514D63C VA: 0x515163C
	public static APIResult<ActionSyncNALinkStateV1.Types.Response> SendWithAuthorize(ActionSyncNALinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51516D8 Offset: 0x514D6D8 VA: 0x51516D8
	public static Task<APIResult<ActionSyncNALinkStateV1.Types.Response>> SendWithAuthorizeAsync(ActionSyncNALinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151784 Offset: 0x514D784 VA: 0x5151784
	public static APIResult<ActionSyncAccountLinkStateV1.Types.Response> Send(ActionSyncAccountLinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151820 Offset: 0x514D820 VA: 0x5151820
	public static Task<APIResult<ActionSyncAccountLinkStateV1.Types.Response>> SendAsync(ActionSyncAccountLinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151914 Offset: 0x514D914 VA: 0x5151914
	public static APIResult<ActionSyncAccountLinkStateV1.Types.Response> SendWithAuthorize(ActionSyncAccountLinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51519B0 Offset: 0x514D9B0 VA: 0x51519B0
	public static Task<APIResult<ActionSyncAccountLinkStateV1.Types.Response>> SendWithAuthorizeAsync(ActionSyncAccountLinkStateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Album // TypeDefIndex: 2341
{
	// Methods

	// RVA: 0x5151E74 Offset: 0x514DE74 VA: 0x5151E74
	public static APIResult<AlbumListV1.Types.Response> Send(AlbumListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5151F10 Offset: 0x514DF10 VA: 0x5151F10
	public static Task<APIResult<AlbumListV1.Types.Response>> SendAsync(AlbumListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152004 Offset: 0x514E004 VA: 0x5152004
	public static APIResult<AlbumListV1.Types.Response> SendWithAuthorize(AlbumListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51520A0 Offset: 0x514E0A0 VA: 0x51520A0
	public static Task<APIResult<AlbumListV1.Types.Response>> SendWithAuthorizeAsync(AlbumListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515214C Offset: 0x514E14C VA: 0x515214C
	public static APIResult<AlbumChangeOrderV1.Types.Response> Send(AlbumChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51521E8 Offset: 0x514E1E8 VA: 0x51521E8
	public static Task<APIResult<AlbumChangeOrderV1.Types.Response>> SendAsync(AlbumChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51522DC Offset: 0x514E2DC VA: 0x51522DC
	public static APIResult<AlbumChangeOrderV1.Types.Response> SendWithAuthorize(AlbumChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152378 Offset: 0x514E378 VA: 0x5152378
	public static Task<APIResult<AlbumChangeOrderV1.Types.Response>> SendWithAuthorizeAsync(AlbumChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152424 Offset: 0x514E424 VA: 0x5152424
	public static APIResult<AlbumGetDetailV1.Types.Response> Send(AlbumGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51524C0 Offset: 0x514E4C0 VA: 0x51524C0
	public static Task<APIResult<AlbumGetDetailV1.Types.Response>> SendAsync(AlbumGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51525B4 Offset: 0x514E5B4 VA: 0x51525B4
	public static APIResult<AlbumGetDetailV1.Types.Response> SendWithAuthorize(AlbumGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152650 Offset: 0x514E650 VA: 0x5152650
	public static Task<APIResult<AlbumGetDetailV1.Types.Response>> SendWithAuthorizeAsync(AlbumGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51526FC Offset: 0x514E6FC VA: 0x51526FC
	public static APIResult<AlbumGetOtherDetailV1.Types.Response> Send(AlbumGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152798 Offset: 0x514E798 VA: 0x5152798
	public static Task<APIResult<AlbumGetOtherDetailV1.Types.Response>> SendAsync(AlbumGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515288C Offset: 0x514E88C VA: 0x515288C
	public static APIResult<AlbumGetOtherDetailV1.Types.Response> SendWithAuthorize(AlbumGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152928 Offset: 0x514E928 VA: 0x5152928
	public static Task<APIResult<AlbumGetOtherDetailV1.Types.Response>> SendWithAuthorizeAsync(AlbumGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51529D4 Offset: 0x514E9D4 VA: 0x51529D4
	public static APIResult<AlbumSetV1.Types.Response> Send(AlbumSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152A70 Offset: 0x514EA70 VA: 0x5152A70
	public static Task<APIResult<AlbumSetV1.Types.Response>> SendAsync(AlbumSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152B64 Offset: 0x514EB64 VA: 0x5152B64
	public static APIResult<AlbumSetV1.Types.Response> SendWithAuthorize(AlbumSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152C00 Offset: 0x514EC00 VA: 0x5152C00
	public static Task<APIResult<AlbumSetV1.Types.Response>> SendWithAuthorizeAsync(AlbumSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152CAC Offset: 0x514ECAC VA: 0x5152CAC
	public static APIResult<AlbumDeleteV1.Types.Response> Send(AlbumDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152D48 Offset: 0x514ED48 VA: 0x5152D48
	public static Task<APIResult<AlbumDeleteV1.Types.Response>> SendAsync(AlbumDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152E3C Offset: 0x514EE3C VA: 0x5152E3C
	public static APIResult<AlbumDeleteV1.Types.Response> SendWithAuthorize(AlbumDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5152ED8 Offset: 0x514EED8 VA: 0x5152ED8
	public static Task<APIResult<AlbumDeleteV1.Types.Response>> SendWithAuthorizeAsync(AlbumDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class AnalyticsLog // TypeDefIndex: 2343
{
	// Methods

	// RVA: 0x51537BC Offset: 0x514F7BC VA: 0x51537BC
	public static APIResult<AnalyticsLogSendV1.Types.Response> Send(AnalyticsLogSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153858 Offset: 0x514F858 VA: 0x5153858
	public static Task<APIResult<AnalyticsLogSendV1.Types.Response>> SendAsync(AnalyticsLogSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515394C Offset: 0x514F94C VA: 0x515394C
	public static APIResult<AnalyticsLogSendV1.Types.Response> SendWithAuthorize(AnalyticsLogSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51539E8 Offset: 0x514F9E8 VA: 0x51539E8
	public static Task<APIResult<AnalyticsLogSendV1.Types.Response>> SendWithAuthorizeAsync(AnalyticsLogSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Card // TypeDefIndex: 2348
{
	// Methods

	// RVA: 0x5153BF0 Offset: 0x514FBF0 VA: 0x5153BF0
	public static APIResult<CardListV1.Types.Response> Send(CardListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153C8C Offset: 0x514FC8C VA: 0x5153C8C
	public static Task<APIResult<CardListV1.Types.Response>> SendAsync(CardListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153D80 Offset: 0x514FD80 VA: 0x5153D80
	public static APIResult<CardListV1.Types.Response> SendWithAuthorize(CardListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153E1C Offset: 0x514FE1C VA: 0x5153E1C
	public static Task<APIResult<CardListV1.Types.Response>> SendWithAuthorizeAsync(CardListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153EC8 Offset: 0x514FEC8 VA: 0x5153EC8
	public static APIResult<CardIsUsedV1.Types.Response> Send(CardIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5153F64 Offset: 0x514FF64 VA: 0x5153F64
	public static Task<APIResult<CardIsUsedV1.Types.Response>> SendAsync(CardIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154058 Offset: 0x5150058 VA: 0x5154058
	public static APIResult<CardIsUsedV1.Types.Response> SendWithAuthorize(CardIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51540F4 Offset: 0x51500F4 VA: 0x51540F4
	public static Task<APIResult<CardIsUsedV1.Types.Response>> SendWithAuthorizeAsync(CardIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51541A0 Offset: 0x51501A0 VA: 0x51541A0
	public static APIResult<CardSetDesiresV1.Types.Response> Send(CardSetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515423C Offset: 0x515023C VA: 0x515423C
	public static Task<APIResult<CardSetDesiresV1.Types.Response>> SendAsync(CardSetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154330 Offset: 0x5150330 VA: 0x5154330
	public static APIResult<CardSetDesiresV1.Types.Response> SendWithAuthorize(CardSetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51543CC Offset: 0x51503CC VA: 0x51543CC
	public static Task<APIResult<CardSetDesiresV1.Types.Response>> SendWithAuthorizeAsync(CardSetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154478 Offset: 0x5150478 VA: 0x5154478
	public static APIResult<CardGetDesiresV1.Types.Response> Send(CardGetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154514 Offset: 0x5150514 VA: 0x5154514
	public static Task<APIResult<CardGetDesiresV1.Types.Response>> SendAsync(CardGetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154608 Offset: 0x5150608 VA: 0x5154608
	public static APIResult<CardGetDesiresV1.Types.Response> SendWithAuthorize(CardGetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51546A4 Offset: 0x51506A4 VA: 0x51546A4
	public static Task<APIResult<CardGetDesiresV1.Types.Response>> SendWithAuthorizeAsync(CardGetDesiresV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class CardSkin // TypeDefIndex: 2355
{
	// Methods

	// RVA: 0x5154CC8 Offset: 0x5150CC8 VA: 0x5154CC8
	public static APIResult<CardSkinListV1.Types.Response> Send(CardSkinListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154D64 Offset: 0x5150D64 VA: 0x5154D64
	public static Task<APIResult<CardSkinListV1.Types.Response>> SendAsync(CardSkinListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154E58 Offset: 0x5150E58 VA: 0x5154E58
	public static APIResult<CardSkinListV1.Types.Response> SendWithAuthorize(CardSkinListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154EF4 Offset: 0x5150EF4 VA: 0x5154EF4
	public static Task<APIResult<CardSkinListV1.Types.Response>> SendWithAuthorizeAsync(CardSkinListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5154FA0 Offset: 0x5150FA0 VA: 0x5154FA0
	public static APIResult<CardSkinExchangeV1.Types.Response> Send(CardSkinExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515503C Offset: 0x515103C VA: 0x515503C
	public static Task<APIResult<CardSkinExchangeV1.Types.Response>> SendAsync(CardSkinExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155130 Offset: 0x5151130 VA: 0x5155130
	public static APIResult<CardSkinExchangeV1.Types.Response> SendWithAuthorize(CardSkinExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51551CC Offset: 0x51511CC VA: 0x51551CC
	public static Task<APIResult<CardSkinExchangeV1.Types.Response>> SendWithAuthorizeAsync(CardSkinExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155278 Offset: 0x5151278 VA: 0x5155278
	public static APIResult<CardSkinGetExchangedCatalogsV1.Types.Response> Send(CardSkinGetExchangedCatalogsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155314 Offset: 0x5151314 VA: 0x5155314
	public static Task<APIResult<CardSkinGetExchangedCatalogsV1.Types.Response>> SendAsync(CardSkinGetExchangedCatalogsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155408 Offset: 0x5151408 VA: 0x5155408
	public static APIResult<CardSkinGetExchangedCatalogsV1.Types.Response> SendWithAuthorize(CardSkinGetExchangedCatalogsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51554A4 Offset: 0x51514A4 VA: 0x51554A4
	public static Task<APIResult<CardSkinGetExchangedCatalogsV1.Types.Response>> SendWithAuthorizeAsync(CardSkinGetExchangedCatalogsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155550 Offset: 0x5151550 VA: 0x5155550
	public static APIResult<CardSkinGetCardExchangeRouteV1.Types.Response> Send(CardSkinGetCardExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51555EC Offset: 0x51515EC VA: 0x51555EC
	public static Task<APIResult<CardSkinGetCardExchangeRouteV1.Types.Response>> SendAsync(CardSkinGetCardExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51556E0 Offset: 0x51516E0 VA: 0x51556E0
	public static APIResult<CardSkinGetCardExchangeRouteV1.Types.Response> SendWithAuthorize(CardSkinGetCardExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515577C Offset: 0x515177C VA: 0x515577C
	public static Task<APIResult<CardSkinGetCardExchangeRouteV1.Types.Response>> SendWithAuthorizeAsync(CardSkinGetCardExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155828 Offset: 0x5151828 VA: 0x5155828
	public static APIResult<CardSkinExchangedCatalogListV1.Types.Response> Send(CardSkinExchangedCatalogListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51558C4 Offset: 0x51518C4 VA: 0x51558C4
	public static Task<APIResult<CardSkinExchangedCatalogListV1.Types.Response>> SendAsync(CardSkinExchangedCatalogListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51559B8 Offset: 0x51519B8 VA: 0x51559B8
	public static APIResult<CardSkinExchangedCatalogListV1.Types.Response> SendWithAuthorize(CardSkinExchangedCatalogListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155A54 Offset: 0x5151A54 VA: 0x5155A54
	public static Task<APIResult<CardSkinExchangedCatalogListV1.Types.Response>> SendWithAuthorizeAsync(CardSkinExchangedCatalogListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155B00 Offset: 0x5151B00 VA: 0x5155B00
	public static APIResult<CardSkinIsUsedV1.Types.Response> Send(CardSkinIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155B9C Offset: 0x5151B9C VA: 0x5155B9C
	public static Task<APIResult<CardSkinIsUsedV1.Types.Response>> SendAsync(CardSkinIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155C90 Offset: 0x5151C90 VA: 0x5155C90
	public static APIResult<CardSkinIsUsedV1.Types.Response> SendWithAuthorize(CardSkinIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5155D2C Offset: 0x5151D2C VA: 0x5155D2C
	public static Task<APIResult<CardSkinIsUsedV1.Types.Response>> SendWithAuthorizeAsync(CardSkinIsUsedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Collection // TypeDefIndex: 2361
{
	// Methods

	// RVA: 0x5156610 Offset: 0x5152610 VA: 0x5156610
	public static APIResult<CollectionGetSomeonesV1.Types.Response> Send(CollectionGetSomeonesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51566AC Offset: 0x51526AC VA: 0x51566AC
	public static Task<APIResult<CollectionGetSomeonesV1.Types.Response>> SendAsync(CollectionGetSomeonesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51567A0 Offset: 0x51527A0 VA: 0x51567A0
	public static APIResult<CollectionGetSomeonesV1.Types.Response> SendWithAuthorize(CollectionGetSomeonesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515683C Offset: 0x515283C VA: 0x515683C
	public static Task<APIResult<CollectionGetSomeonesV1.Types.Response>> SendWithAuthorizeAsync(CollectionGetSomeonesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51568E8 Offset: 0x51528E8 VA: 0x51568E8
	public static APIResult<CollectionListV1.Types.Response> Send(CollectionListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156984 Offset: 0x5152984 VA: 0x5156984
	public static Task<APIResult<CollectionListV1.Types.Response>> SendAsync(CollectionListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156A78 Offset: 0x5152A78 VA: 0x5156A78
	public static APIResult<CollectionListV1.Types.Response> SendWithAuthorize(CollectionListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156B14 Offset: 0x5152B14 VA: 0x5156B14
	public static Task<APIResult<CollectionListV1.Types.Response>> SendWithAuthorizeAsync(CollectionListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156BC0 Offset: 0x5152BC0 VA: 0x5156BC0
	public static APIResult<CollectionOtherListV1.Types.Response> Send(CollectionOtherListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156C5C Offset: 0x5152C5C VA: 0x5156C5C
	public static Task<APIResult<CollectionOtherListV1.Types.Response>> SendAsync(CollectionOtherListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156D50 Offset: 0x5152D50 VA: 0x5156D50
	public static APIResult<CollectionOtherListV1.Types.Response> SendWithAuthorize(CollectionOtherListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156DEC Offset: 0x5152DEC VA: 0x5156DEC
	public static Task<APIResult<CollectionOtherListV1.Types.Response>> SendWithAuthorizeAsync(CollectionOtherListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156E98 Offset: 0x5152E98 VA: 0x5156E98
	public static APIResult<CollectionSetMyBestV1.Types.Response> Send(CollectionSetMyBestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5156F34 Offset: 0x5152F34 VA: 0x5156F34
	public static Task<APIResult<CollectionSetMyBestV1.Types.Response>> SendAsync(CollectionSetMyBestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157028 Offset: 0x5153028 VA: 0x5157028
	public static APIResult<CollectionSetMyBestV1.Types.Response> SendWithAuthorize(CollectionSetMyBestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51570C4 Offset: 0x51530C4 VA: 0x51570C4
	public static Task<APIResult<CollectionSetMyBestV1.Types.Response>> SendWithAuthorizeAsync(CollectionSetMyBestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157170 Offset: 0x5153170 VA: 0x5157170
	public static APIResult<CollectionLikeV1.Types.Response> Send(CollectionLikeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515720C Offset: 0x515320C VA: 0x515720C
	public static Task<APIResult<CollectionLikeV1.Types.Response>> SendAsync(CollectionLikeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157300 Offset: 0x5153300 VA: 0x5157300
	public static APIResult<CollectionLikeV1.Types.Response> SendWithAuthorize(CollectionLikeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515739C Offset: 0x515339C VA: 0x515739C
	public static Task<APIResult<CollectionLikeV1.Types.Response>> SendWithAuthorizeAsync(CollectionLikeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Deck // TypeDefIndex: 2366
{
	// Methods

	// RVA: 0x5157B20 Offset: 0x5153B20 VA: 0x5157B20
	public static APIResult<DeckGetListV1.Types.Response> Send(DeckGetListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157BBC Offset: 0x5153BBC VA: 0x5157BBC
	public static Task<APIResult<DeckGetListV1.Types.Response>> SendAsync(DeckGetListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157CB0 Offset: 0x5153CB0 VA: 0x5157CB0
	public static APIResult<DeckGetListV1.Types.Response> SendWithAuthorize(DeckGetListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157D4C Offset: 0x5153D4C VA: 0x5157D4C
	public static Task<APIResult<DeckGetListV1.Types.Response>> SendWithAuthorizeAsync(DeckGetListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157DF8 Offset: 0x5153DF8 VA: 0x5157DF8
	public static APIResult<DeckSaveV1.Types.Response> Send(DeckSaveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157E94 Offset: 0x5153E94 VA: 0x5157E94
	public static Task<APIResult<DeckSaveV1.Types.Response>> SendAsync(DeckSaveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5157F88 Offset: 0x5153F88 VA: 0x5157F88
	public static APIResult<DeckSaveV1.Types.Response> SendWithAuthorize(DeckSaveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158024 Offset: 0x5154024 VA: 0x5158024
	public static Task<APIResult<DeckSaveV1.Types.Response>> SendWithAuthorizeAsync(DeckSaveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51580D0 Offset: 0x51540D0 VA: 0x51580D0
	public static APIResult<DeckDeleteV1.Types.Response> Send(DeckDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515816C Offset: 0x515416C VA: 0x515816C
	public static Task<APIResult<DeckDeleteV1.Types.Response>> SendAsync(DeckDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158260 Offset: 0x5154260 VA: 0x5158260
	public static APIResult<DeckDeleteV1.Types.Response> SendWithAuthorize(DeckDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51582FC Offset: 0x51542FC VA: 0x51582FC
	public static Task<APIResult<DeckDeleteV1.Types.Response>> SendWithAuthorizeAsync(DeckDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51583A8 Offset: 0x51543A8 VA: 0x51583A8
	public static APIResult<DeckGetRentalDecksV1.Types.Response> Send(DeckGetRentalDecksV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158444 Offset: 0x5154444 VA: 0x5158444
	public static Task<APIResult<DeckGetRentalDecksV1.Types.Response>> SendAsync(DeckGetRentalDecksV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158538 Offset: 0x5154538 VA: 0x5158538
	public static APIResult<DeckGetRentalDecksV1.Types.Response> SendWithAuthorize(DeckGetRentalDecksV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51585D4 Offset: 0x51545D4 VA: 0x51585D4
	public static Task<APIResult<DeckGetRentalDecksV1.Types.Response>> SendWithAuthorizeAsync(DeckGetRentalDecksV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Echo // TypeDefIndex: 2368
{
	// Methods

	// RVA: 0x5158BF8 Offset: 0x5154BF8 VA: 0x5158BF8
	public static APIResult<EchoEchoV1.Types.Response> Send(EchoEchoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158C94 Offset: 0x5154C94 VA: 0x5158C94
	public static Task<APIResult<EchoEchoV1.Types.Response>> SendAsync(EchoEchoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158D88 Offset: 0x5154D88 VA: 0x5158D88
	public static APIResult<EchoEchoV1.Types.Response> SendWithAuthorize(EchoEchoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5158E24 Offset: 0x5154E24 VA: 0x5158E24
	public static Task<APIResult<EchoEchoV1.Types.Response>> SendWithAuthorizeAsync(EchoEchoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Fave // TypeDefIndex: 2370
{
	// Methods

	// RVA: 0x515902C Offset: 0x515502C VA: 0x515902C
	public static APIResult<FaveInsightV1.Types.Response> Send(FaveInsightV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51590C8 Offset: 0x51550C8 VA: 0x51590C8
	public static Task<APIResult<FaveInsightV1.Types.Response>> SendAsync(FaveInsightV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51591BC Offset: 0x51551BC VA: 0x51591BC
	public static APIResult<FaveInsightV1.Types.Response> SendWithAuthorize(FaveInsightV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159258 Offset: 0x5155258 VA: 0x5159258
	public static Task<APIResult<FaveInsightV1.Types.Response>> SendWithAuthorizeAsync(FaveInsightV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Feed // TypeDefIndex: 2378
{
	// Methods

	// RVA: 0x5159460 Offset: 0x5155460 VA: 0x5159460
	public static APIResult<FeedGetTimelineV1.Types.Response> Send(FeedGetTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51594FC Offset: 0x51554FC VA: 0x51594FC
	public static Task<APIResult<FeedGetTimelineV1.Types.Response>> SendAsync(FeedGetTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51595F0 Offset: 0x51555F0 VA: 0x51595F0
	public static APIResult<FeedGetTimelineV1.Types.Response> SendWithAuthorize(FeedGetTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515968C Offset: 0x515568C VA: 0x515968C
	public static Task<APIResult<FeedGetTimelineV1.Types.Response>> SendWithAuthorizeAsync(FeedGetTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159738 Offset: 0x5155738 VA: 0x5159738
	public static APIResult<FeedRenewTimelineV1.Types.Response> Send(FeedRenewTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51597D4 Offset: 0x51557D4 VA: 0x51597D4
	public static Task<APIResult<FeedRenewTimelineV1.Types.Response>> SendAsync(FeedRenewTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51598C8 Offset: 0x51558C8 VA: 0x51598C8
	public static APIResult<FeedRenewTimelineV1.Types.Response> SendWithAuthorize(FeedRenewTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159964 Offset: 0x5155964 VA: 0x5159964
	public static Task<APIResult<FeedRenewTimelineV1.Types.Response>> SendWithAuthorizeAsync(FeedRenewTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159A10 Offset: 0x5155A10 VA: 0x5159A10
	public static APIResult<FeedChallengeV1.Types.Response> Send(FeedChallengeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159AAC Offset: 0x5155AAC VA: 0x5159AAC
	public static Task<APIResult<FeedChallengeV1.Types.Response>> SendAsync(FeedChallengeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159BA0 Offset: 0x5155BA0 VA: 0x5159BA0
	public static APIResult<FeedChallengeV1.Types.Response> SendWithAuthorize(FeedChallengeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159C3C Offset: 0x5155C3C VA: 0x5159C3C
	public static Task<APIResult<FeedChallengeV1.Types.Response>> SendWithAuthorizeAsync(FeedChallengeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159CE8 Offset: 0x5155CE8 VA: 0x5159CE8
	public static APIResult<FeedHealChallengePowerV1.Types.Response> Send(FeedHealChallengePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159D84 Offset: 0x5155D84 VA: 0x5159D84
	public static Task<APIResult<FeedHealChallengePowerV1.Types.Response>> SendAsync(FeedHealChallengePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159E78 Offset: 0x5155E78 VA: 0x5159E78
	public static APIResult<FeedHealChallengePowerV1.Types.Response> SendWithAuthorize(FeedHealChallengePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159F14 Offset: 0x5155F14 VA: 0x5159F14
	public static Task<APIResult<FeedHealChallengePowerV1.Types.Response>> SendWithAuthorizeAsync(FeedHealChallengePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5159FC0 Offset: 0x5155FC0 VA: 0x5159FC0
	public static APIResult<FeedShareV1.Types.Response> Send(FeedShareV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A05C Offset: 0x515605C VA: 0x515A05C
	public static Task<APIResult<FeedShareV1.Types.Response>> SendAsync(FeedShareV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A150 Offset: 0x5156150 VA: 0x515A150
	public static APIResult<FeedShareV1.Types.Response> SendWithAuthorize(FeedShareV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A1EC Offset: 0x51561EC VA: 0x515A1EC
	public static Task<APIResult<FeedShareV1.Types.Response>> SendWithAuthorizeAsync(FeedShareV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A298 Offset: 0x5156298 VA: 0x515A298
	public static APIResult<FeedSnoopV1.Types.Response> Send(FeedSnoopV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A334 Offset: 0x5156334 VA: 0x515A334
	public static Task<APIResult<FeedSnoopV1.Types.Response>> SendAsync(FeedSnoopV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A428 Offset: 0x5156428 VA: 0x515A428
	public static APIResult<FeedSnoopV1.Types.Response> SendWithAuthorize(FeedSnoopV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A4C4 Offset: 0x51564C4 VA: 0x515A4C4
	public static Task<APIResult<FeedSnoopV1.Types.Response>> SendWithAuthorizeAsync(FeedSnoopV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A570 Offset: 0x5156570 VA: 0x515A570
	public static APIResult<FeedChallengeV2.Types.Response> Send(FeedChallengeV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A60C Offset: 0x515660C VA: 0x515A60C
	public static Task<APIResult<FeedChallengeV2.Types.Response>> SendAsync(FeedChallengeV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A700 Offset: 0x5156700 VA: 0x515A700
	public static APIResult<FeedChallengeV2.Types.Response> SendWithAuthorize(FeedChallengeV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515A79C Offset: 0x515679C VA: 0x515A79C
	public static Task<APIResult<FeedChallengeV2.Types.Response>> SendWithAuthorizeAsync(FeedChallengeV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Friend // TypeDefIndex: 2386
{
	// Methods

	// RVA: 0x515B1E0 Offset: 0x51571E0 VA: 0x515B1E0
	public static APIResult<FriendListV1.Types.Response> Send(FriendListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B27C Offset: 0x515727C VA: 0x515B27C
	public static Task<APIResult<FriendListV1.Types.Response>> SendAsync(FriendListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B370 Offset: 0x5157370 VA: 0x515B370
	public static APIResult<FriendListV1.Types.Response> SendWithAuthorize(FriendListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B40C Offset: 0x515740C VA: 0x515B40C
	public static Task<APIResult<FriendListV1.Types.Response>> SendWithAuthorizeAsync(FriendListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B4B8 Offset: 0x51574B8 VA: 0x515B4B8
	public static APIResult<FriendSendRequestsV1.Types.Response> Send(FriendSendRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B554 Offset: 0x5157554 VA: 0x515B554
	public static Task<APIResult<FriendSendRequestsV1.Types.Response>> SendAsync(FriendSendRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B604 Offset: 0x5157604 VA: 0x515B604
	public static APIResult<FriendSendRequestsV1.Types.Response> SendWithAuthorize(FriendSendRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B6A0 Offset: 0x51576A0 VA: 0x515B6A0
	public static Task<APIResult<FriendSendRequestsV1.Types.Response>> SendWithAuthorizeAsync(FriendSendRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B750 Offset: 0x5157750 VA: 0x515B750
	public static APIResult<FriendCancelSentRequestsV1.Types.Response> Send(FriendCancelSentRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B7EC Offset: 0x51577EC VA: 0x515B7EC
	public static Task<APIResult<FriendCancelSentRequestsV1.Types.Response>> SendAsync(FriendCancelSentRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B89C Offset: 0x515789C VA: 0x515B89C
	public static APIResult<FriendCancelSentRequestsV1.Types.Response> SendWithAuthorize(FriendCancelSentRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B938 Offset: 0x5157938 VA: 0x515B938
	public static Task<APIResult<FriendCancelSentRequestsV1.Types.Response>> SendWithAuthorizeAsync(FriendCancelSentRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515B9E8 Offset: 0x51579E8 VA: 0x515B9E8
	public static APIResult<FriendApproveRequestV1.Types.Response> Send(FriendApproveRequestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BA84 Offset: 0x5157A84 VA: 0x515BA84
	public static Task<APIResult<FriendApproveRequestV1.Types.Response>> SendAsync(FriendApproveRequestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BB34 Offset: 0x5157B34 VA: 0x515BB34
	public static APIResult<FriendApproveRequestV1.Types.Response> SendWithAuthorize(FriendApproveRequestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BBD0 Offset: 0x5157BD0 VA: 0x515BBD0
	public static Task<APIResult<FriendApproveRequestV1.Types.Response>> SendWithAuthorizeAsync(FriendApproveRequestV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BC80 Offset: 0x5157C80 VA: 0x515BC80
	public static APIResult<FriendRejectRequestsV1.Types.Response> Send(FriendRejectRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BD1C Offset: 0x5157D1C VA: 0x515BD1C
	public static Task<APIResult<FriendRejectRequestsV1.Types.Response>> SendAsync(FriendRejectRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BDCC Offset: 0x5157DCC VA: 0x515BDCC
	public static APIResult<FriendRejectRequestsV1.Types.Response> SendWithAuthorize(FriendRejectRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BE68 Offset: 0x5157E68 VA: 0x515BE68
	public static Task<APIResult<FriendRejectRequestsV1.Types.Response>> SendWithAuthorizeAsync(FriendRejectRequestsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BF18 Offset: 0x5157F18 VA: 0x515BF18
	public static APIResult<FriendDeleteV1.Types.Response> Send(FriendDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515BFB4 Offset: 0x5157FB4 VA: 0x515BFB4
	public static Task<APIResult<FriendDeleteV1.Types.Response>> SendAsync(FriendDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C064 Offset: 0x5158064 VA: 0x515C064
	public static APIResult<FriendDeleteV1.Types.Response> SendWithAuthorize(FriendDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C100 Offset: 0x5158100 VA: 0x515C100
	public static Task<APIResult<FriendDeleteV1.Types.Response>> SendWithAuthorizeAsync(FriendDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C1B0 Offset: 0x51581B0 VA: 0x515C1B0
	public static APIResult<FriendSearchV1.Types.Response> Send(FriendSearchV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C24C Offset: 0x515824C VA: 0x515C24C
	public static Task<APIResult<FriendSearchV1.Types.Response>> SendAsync(FriendSearchV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C2FC Offset: 0x51582FC VA: 0x515C2FC
	public static APIResult<FriendSearchV1.Types.Response> SendWithAuthorize(FriendSearchV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515C398 Offset: 0x5158398 VA: 0x515C398
	public static Task<APIResult<FriendSearchV1.Types.Response>> SendWithAuthorizeAsync(FriendSearchV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class ItemShop // TypeDefIndex: 2391
{
	// Methods

	// RVA: 0x515CFA8 Offset: 0x5158FA8 VA: 0x515CFA8
	public static APIResult<ItemShopGetPurchaseSummariesV1.Types.Response> Send(ItemShopGetPurchaseSummariesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D044 Offset: 0x5159044 VA: 0x515D044
	public static Task<APIResult<ItemShopGetPurchaseSummariesV1.Types.Response>> SendAsync(ItemShopGetPurchaseSummariesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D138 Offset: 0x5159138 VA: 0x515D138
	public static APIResult<ItemShopGetPurchaseSummariesV1.Types.Response> SendWithAuthorize(ItemShopGetPurchaseSummariesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D1D4 Offset: 0x51591D4 VA: 0x515D1D4
	public static Task<APIResult<ItemShopGetPurchaseSummariesV1.Types.Response>> SendWithAuthorizeAsync(ItemShopGetPurchaseSummariesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D280 Offset: 0x5159280 VA: 0x515D280
	public static APIResult<ItemShopPurchaseV1.Types.Response> Send(ItemShopPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D31C Offset: 0x515931C VA: 0x515D31C
	public static Task<APIResult<ItemShopPurchaseV1.Types.Response>> SendAsync(ItemShopPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D410 Offset: 0x5159410 VA: 0x515D410
	public static APIResult<ItemShopPurchaseV1.Types.Response> SendWithAuthorize(ItemShopPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D4AC Offset: 0x51594AC VA: 0x515D4AC
	public static Task<APIResult<ItemShopPurchaseV1.Types.Response>> SendWithAuthorizeAsync(ItemShopPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D558 Offset: 0x5159558 VA: 0x515D558
	public static APIResult<ItemShopExchangeV1.Types.Response> Send(ItemShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D5F4 Offset: 0x51595F4 VA: 0x515D5F4
	public static Task<APIResult<ItemShopExchangeV1.Types.Response>> SendAsync(ItemShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D6E8 Offset: 0x51596E8 VA: 0x515D6E8
	public static APIResult<ItemShopExchangeV1.Types.Response> SendWithAuthorize(ItemShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D784 Offset: 0x5159784 VA: 0x515D784
	public static Task<APIResult<ItemShopExchangeV1.Types.Response>> SendWithAuthorizeAsync(ItemShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D830 Offset: 0x5159830 VA: 0x515D830
	public static APIResult<ItemShopLiquidateV1.Types.Response> Send(ItemShopLiquidateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D8CC Offset: 0x51598CC VA: 0x515D8CC
	public static Task<APIResult<ItemShopLiquidateV1.Types.Response>> SendAsync(ItemShopLiquidateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515D9C0 Offset: 0x51599C0 VA: 0x515D9C0
	public static APIResult<ItemShopLiquidateV1.Types.Response> SendWithAuthorize(ItemShopLiquidateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515DA5C Offset: 0x5159A5C VA: 0x515DA5C
	public static Task<APIResult<ItemShopLiquidateV1.Types.Response>> SendWithAuthorizeAsync(ItemShopLiquidateV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Mission // TypeDefIndex: 2398
{
	// Methods

	// RVA: 0x515E090 Offset: 0x515A090 VA: 0x515E090
	public static APIResult<MissionCompleteV2.Types.Response> Send(MissionCompleteV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E12C Offset: 0x515A12C VA: 0x515E12C
	public static Task<APIResult<MissionCompleteV2.Types.Response>> SendAsync(MissionCompleteV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E220 Offset: 0x515A220 VA: 0x515E220
	public static APIResult<MissionCompleteV2.Types.Response> SendWithAuthorize(MissionCompleteV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E2BC Offset: 0x515A2BC VA: 0x515E2BC
	public static Task<APIResult<MissionCompleteV2.Types.Response>> SendWithAuthorizeAsync(MissionCompleteV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E368 Offset: 0x515A368 VA: 0x515E368
	public static APIResult<MissionIsCompletedV1.Types.Response> Send(MissionIsCompletedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E404 Offset: 0x515A404 VA: 0x515E404
	public static Task<APIResult<MissionIsCompletedV1.Types.Response>> SendAsync(MissionIsCompletedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E4F8 Offset: 0x515A4F8 VA: 0x515E4F8
	public static APIResult<MissionIsCompletedV1.Types.Response> SendWithAuthorize(MissionIsCompletedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E594 Offset: 0x515A594 VA: 0x515E594
	public static Task<APIResult<MissionIsCompletedV1.Types.Response>> SendWithAuthorizeAsync(MissionIsCompletedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E640 Offset: 0x515A640 VA: 0x515E640
	public static APIResult<MissionIsNotifiedV1.Types.Response> Send(MissionIsNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E6DC Offset: 0x515A6DC VA: 0x515E6DC
	public static Task<APIResult<MissionIsNotifiedV1.Types.Response>> SendAsync(MissionIsNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E7D0 Offset: 0x515A7D0 VA: 0x515E7D0
	public static APIResult<MissionIsNotifiedV1.Types.Response> SendWithAuthorize(MissionIsNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E86C Offset: 0x515A86C VA: 0x515E86C
	public static Task<APIResult<MissionIsNotifiedV1.Types.Response>> SendWithAuthorizeAsync(MissionIsNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E918 Offset: 0x515A918 VA: 0x515E918
	public static APIResult<MissionSetNotifiedV1.Types.Response> Send(MissionSetNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515E9B4 Offset: 0x515A9B4 VA: 0x515E9B4
	public static Task<APIResult<MissionSetNotifiedV1.Types.Response>> SendAsync(MissionSetNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EAA8 Offset: 0x515AAA8 VA: 0x515EAA8
	public static APIResult<MissionSetNotifiedV1.Types.Response> SendWithAuthorize(MissionSetNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EB44 Offset: 0x515AB44 VA: 0x515EB44
	public static Task<APIResult<MissionSetNotifiedV1.Types.Response>> SendWithAuthorizeAsync(MissionSetNotifiedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EBF0 Offset: 0x515ABF0 VA: 0x515EBF0
	public static APIResult<MissionGetGroupRewardStepStatesV1.Types.Response> Send(MissionGetGroupRewardStepStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EC8C Offset: 0x515AC8C VA: 0x515EC8C
	public static Task<APIResult<MissionGetGroupRewardStepStatesV1.Types.Response>> SendAsync(MissionGetGroupRewardStepStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515ED80 Offset: 0x515AD80 VA: 0x515ED80
	public static APIResult<MissionGetGroupRewardStepStatesV1.Types.Response> SendWithAuthorize(MissionGetGroupRewardStepStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EE1C Offset: 0x515AE1C VA: 0x515EE1C
	public static Task<APIResult<MissionGetGroupRewardStepStatesV1.Types.Response>> SendWithAuthorizeAsync(MissionGetGroupRewardStepStatesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EEC8 Offset: 0x515AEC8 VA: 0x515EEC8
	public static APIResult<MissionCompleteGroupRewardStepV1.Types.Response> Send(MissionCompleteGroupRewardStepV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515EF64 Offset: 0x515AF64 VA: 0x515EF64
	public static Task<APIResult<MissionCompleteGroupRewardStepV1.Types.Response>> SendAsync(MissionCompleteGroupRewardStepV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515F058 Offset: 0x515B058 VA: 0x515F058
	public static APIResult<MissionCompleteGroupRewardStepV1.Types.Response> SendWithAuthorize(MissionCompleteGroupRewardStepV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515F0F4 Offset: 0x515B0F4 VA: 0x515F0F4
	public static Task<APIResult<MissionCompleteGroupRewardStepV1.Types.Response>> SendWithAuthorizeAsync(MissionCompleteGroupRewardStepV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Mount // TypeDefIndex: 2405
{
	// Methods

	// RVA: 0x515F9F0 Offset: 0x515B9F0 VA: 0x515F9F0
	public static APIResult<MountListV1.Types.Response> Send(MountListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FA8C Offset: 0x515BA8C VA: 0x515FA8C
	public static Task<APIResult<MountListV1.Types.Response>> SendAsync(MountListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FB80 Offset: 0x515BB80 VA: 0x515FB80
	public static APIResult<MountListV1.Types.Response> SendWithAuthorize(MountListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FC1C Offset: 0x515BC1C VA: 0x515FC1C
	public static Task<APIResult<MountListV1.Types.Response>> SendWithAuthorizeAsync(MountListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FCC8 Offset: 0x515BCC8 VA: 0x515FCC8
	public static APIResult<MountChangeOrderV1.Types.Response> Send(MountChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FD64 Offset: 0x515BD64 VA: 0x515FD64
	public static Task<APIResult<MountChangeOrderV1.Types.Response>> SendAsync(MountChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FE58 Offset: 0x515BE58 VA: 0x515FE58
	public static APIResult<MountChangeOrderV1.Types.Response> SendWithAuthorize(MountChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FEF4 Offset: 0x515BEF4 VA: 0x515FEF4
	public static Task<APIResult<MountChangeOrderV1.Types.Response>> SendWithAuthorizeAsync(MountChangeOrderV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x515FFA0 Offset: 0x515BFA0 VA: 0x515FFA0
	public static APIResult<MountGetDetailV1.Types.Response> Send(MountGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516003C Offset: 0x515C03C VA: 0x516003C
	public static Task<APIResult<MountGetDetailV1.Types.Response>> SendAsync(MountGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160130 Offset: 0x515C130 VA: 0x5160130
	public static APIResult<MountGetDetailV1.Types.Response> SendWithAuthorize(MountGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51601CC Offset: 0x515C1CC VA: 0x51601CC
	public static Task<APIResult<MountGetDetailV1.Types.Response>> SendWithAuthorizeAsync(MountGetDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160278 Offset: 0x515C278 VA: 0x5160278
	public static APIResult<MountGetOtherDetailV1.Types.Response> Send(MountGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160314 Offset: 0x515C314 VA: 0x5160314
	public static Task<APIResult<MountGetOtherDetailV1.Types.Response>> SendAsync(MountGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160408 Offset: 0x515C408 VA: 0x5160408
	public static APIResult<MountGetOtherDetailV1.Types.Response> SendWithAuthorize(MountGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51604A4 Offset: 0x515C4A4 VA: 0x51604A4
	public static Task<APIResult<MountGetOtherDetailV1.Types.Response>> SendWithAuthorizeAsync(MountGetOtherDetailV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160550 Offset: 0x515C550 VA: 0x5160550
	public static APIResult<MountSetV1.Types.Response> Send(MountSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51605EC Offset: 0x515C5EC VA: 0x51605EC
	public static Task<APIResult<MountSetV1.Types.Response>> SendAsync(MountSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51606E0 Offset: 0x515C6E0 VA: 0x51606E0
	public static APIResult<MountSetV1.Types.Response> SendWithAuthorize(MountSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516077C Offset: 0x515C77C VA: 0x516077C
	public static Task<APIResult<MountSetV1.Types.Response>> SendWithAuthorizeAsync(MountSetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160828 Offset: 0x515C828 VA: 0x5160828
	public static APIResult<MountDeleteV1.Types.Response> Send(MountDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51608C4 Offset: 0x515C8C4 VA: 0x51608C4
	public static Task<APIResult<MountDeleteV1.Types.Response>> SendAsync(MountDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51609B8 Offset: 0x515C9B8 VA: 0x51609B8
	public static APIResult<MountDeleteV1.Types.Response> SendWithAuthorize(MountDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5160A54 Offset: 0x515CA54 VA: 0x5160A54
	public static Task<APIResult<MountDeleteV1.Types.Response>> SendWithAuthorizeAsync(MountDeleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Notification // TypeDefIndex: 2408
{
	// Methods

	// RVA: 0x5161350 Offset: 0x515D350 VA: 0x5161350
	public static APIResult<NotificationGetSettingsV1.Types.Response> Send(NotificationGetSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51613EC Offset: 0x515D3EC VA: 0x51613EC
	public static Task<APIResult<NotificationGetSettingsV1.Types.Response>> SendAsync(NotificationGetSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51614E0 Offset: 0x515D4E0 VA: 0x51614E0
	public static APIResult<NotificationGetSettingsV1.Types.Response> SendWithAuthorize(NotificationGetSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516157C Offset: 0x515D57C VA: 0x516157C
	public static Task<APIResult<NotificationGetSettingsV1.Types.Response>> SendWithAuthorizeAsync(NotificationGetSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161628 Offset: 0x515D628 VA: 0x5161628
	public static APIResult<NotificationSaveSettingsV1.Types.Response> Send(NotificationSaveSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51616C4 Offset: 0x515D6C4 VA: 0x51616C4
	public static Task<APIResult<NotificationSaveSettingsV1.Types.Response>> SendAsync(NotificationSaveSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51617B8 Offset: 0x515D7B8 VA: 0x51617B8
	public static APIResult<NotificationSaveSettingsV1.Types.Response> SendWithAuthorize(NotificationSaveSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161854 Offset: 0x515D854 VA: 0x5161854
	public static Task<APIResult<NotificationSaveSettingsV1.Types.Response>> SendWithAuthorizeAsync(NotificationSaveSettingsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Pack // TypeDefIndex: 2411
{
	// Methods

	// RVA: 0x5161BC0 Offset: 0x515DBC0 VA: 0x5161BC0
	public static APIResult<PackGetPackPowerV1.Types.Response> Send(PackGetPackPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161C5C Offset: 0x515DC5C VA: 0x5161C5C
	public static Task<APIResult<PackGetPackPowerV1.Types.Response>> SendAsync(PackGetPackPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161D50 Offset: 0x515DD50 VA: 0x5161D50
	public static APIResult<PackGetPackPowerV1.Types.Response> SendWithAuthorize(PackGetPackPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161DEC Offset: 0x515DDEC VA: 0x5161DEC
	public static Task<APIResult<PackGetPackPowerV1.Types.Response>> SendWithAuthorizeAsync(PackGetPackPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161E98 Offset: 0x515DE98 VA: 0x5161E98
	public static APIResult<PackGetDetailV2.Types.Response> Send(PackGetDetailV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5161F34 Offset: 0x515DF34 VA: 0x5161F34
	public static Task<APIResult<PackGetDetailV2.Types.Response>> SendAsync(PackGetDetailV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162028 Offset: 0x515E028 VA: 0x5162028
	public static APIResult<PackGetDetailV2.Types.Response> SendWithAuthorize(PackGetDetailV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51620C4 Offset: 0x515E0C4 VA: 0x51620C4
	public static Task<APIResult<PackGetDetailV2.Types.Response>> SendWithAuthorizeAsync(PackGetDetailV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PackShop // TypeDefIndex: 2414
{
	// Methods

	// RVA: 0x5162430 Offset: 0x515E430 VA: 0x5162430
	public static APIResult<PackShopPurchaseV2.Types.Response> Send(PackShopPurchaseV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51624CC Offset: 0x515E4CC VA: 0x51624CC
	public static Task<APIResult<PackShopPurchaseV2.Types.Response>> SendAsync(PackShopPurchaseV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51625C0 Offset: 0x515E5C0 VA: 0x51625C0
	public static APIResult<PackShopPurchaseV2.Types.Response> SendWithAuthorize(PackShopPurchaseV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516265C Offset: 0x515E65C VA: 0x516265C
	public static Task<APIResult<PackShopPurchaseV2.Types.Response>> SendWithAuthorizeAsync(PackShopPurchaseV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162708 Offset: 0x515E708 VA: 0x5162708
	public static APIResult<PackShopExchangeV1.Types.Response> Send(PackShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51627A4 Offset: 0x515E7A4 VA: 0x51627A4
	public static Task<APIResult<PackShopExchangeV1.Types.Response>> SendAsync(PackShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162898 Offset: 0x515E898 VA: 0x5162898
	public static APIResult<PackShopExchangeV1.Types.Response> SendWithAuthorize(PackShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162934 Offset: 0x515E934 VA: 0x5162934
	public static Task<APIResult<PackShopExchangeV1.Types.Response>> SendWithAuthorizeAsync(PackShopExchangeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Pass // TypeDefIndex: 2416
{
	// Methods

	// RVA: 0x5162CA0 Offset: 0x515ECA0 VA: 0x5162CA0
	public static APIResult<PassGetEntitlementsV1.Types.Response> Send(PassGetEntitlementsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162D3C Offset: 0x515ED3C VA: 0x5162D3C
	public static Task<APIResult<PassGetEntitlementsV1.Types.Response>> SendAsync(PassGetEntitlementsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162E30 Offset: 0x515EE30 VA: 0x5162E30
	public static APIResult<PassGetEntitlementsV1.Types.Response> SendWithAuthorize(PassGetEntitlementsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5162ECC Offset: 0x515EECC VA: 0x5162ECC
	public static Task<APIResult<PassGetEntitlementsV1.Types.Response>> SendWithAuthorizeAsync(PassGetEntitlementsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Player // TypeDefIndex: 2419
{
	// Methods

	// RVA: 0x51630D8 Offset: 0x515F0D8 VA: 0x51630D8
	public static APIResult<PlayerDeleteAccountV1.Types.Response> Send(PlayerDeleteAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163174 Offset: 0x515F174 VA: 0x5163174
	public static Task<APIResult<PlayerDeleteAccountV1.Types.Response>> SendAsync(PlayerDeleteAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163268 Offset: 0x515F268 VA: 0x5163268
	public static APIResult<PlayerDeleteAccountV1.Types.Response> SendWithAuthorize(PlayerDeleteAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163304 Offset: 0x515F304 VA: 0x5163304
	public static Task<APIResult<PlayerDeleteAccountV1.Types.Response>> SendWithAuthorizeAsync(PlayerDeleteAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51633B0 Offset: 0x515F3B0 VA: 0x51633B0
	public static APIResult<PlayerUnlinkAccountV1.Types.Response> Send(PlayerUnlinkAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516344C Offset: 0x515F44C VA: 0x516344C
	public static Task<APIResult<PlayerUnlinkAccountV1.Types.Response>> SendAsync(PlayerUnlinkAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163540 Offset: 0x515F540 VA: 0x5163540
	public static APIResult<PlayerUnlinkAccountV1.Types.Response> SendWithAuthorize(PlayerUnlinkAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51635DC Offset: 0x515F5DC VA: 0x51635DC
	public static Task<APIResult<PlayerUnlinkAccountV1.Types.Response>> SendWithAuthorizeAsync(PlayerUnlinkAccountV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PlayerLevel // TypeDefIndex: 2421
{
	// Methods

	// RVA: 0x5163948 Offset: 0x515F948 VA: 0x5163948
	public static APIResult<PlayerLevelMayLevelUpV1.Types.Response> Send(PlayerLevelMayLevelUpV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51639E4 Offset: 0x515F9E4 VA: 0x51639E4
	public static Task<APIResult<PlayerLevelMayLevelUpV1.Types.Response>> SendAsync(PlayerLevelMayLevelUpV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163AD8 Offset: 0x515FAD8 VA: 0x5163AD8
	public static APIResult<PlayerLevelMayLevelUpV1.Types.Response> SendWithAuthorize(PlayerLevelMayLevelUpV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163B74 Offset: 0x515FB74 VA: 0x5163B74
	public static Task<APIResult<PlayerLevelMayLevelUpV1.Types.Response>> SendWithAuthorizeAsync(PlayerLevelMayLevelUpV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PlayerProfile // TypeDefIndex: 2425
{
	// Methods

	// RVA: 0x5163D80 Offset: 0x515FD80 VA: 0x5163D80
	public static APIResult<MyProfileV1.Types.Response> Send(MyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163E1C Offset: 0x515FE1C VA: 0x5163E1C
	public static Task<APIResult<MyProfileV1.Types.Response>> SendAsync(MyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163F10 Offset: 0x515FF10 VA: 0x5163F10
	public static APIResult<MyProfileV1.Types.Response> SendWithAuthorize(MyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5163FAC Offset: 0x515FFAC VA: 0x5163FAC
	public static Task<APIResult<MyProfileV1.Types.Response>> SendWithAuthorizeAsync(MyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164058 Offset: 0x5160058 VA: 0x5164058
	public static APIResult<OtherPlayerProfileV1.Types.Response> Send(OtherPlayerProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51640F4 Offset: 0x51600F4 VA: 0x51640F4
	public static Task<APIResult<OtherPlayerProfileV1.Types.Response>> SendAsync(OtherPlayerProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51641E8 Offset: 0x51601E8 VA: 0x51641E8
	public static APIResult<OtherPlayerProfileV1.Types.Response> SendWithAuthorize(OtherPlayerProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164284 Offset: 0x5160284 VA: 0x5164284
	public static Task<APIResult<OtherPlayerProfileV1.Types.Response>> SendWithAuthorizeAsync(OtherPlayerProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164330 Offset: 0x5160330 VA: 0x5164330
	public static APIResult<SaveMyProfileV1.Types.Response> Send(SaveMyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51643CC Offset: 0x51603CC VA: 0x51643CC
	public static Task<APIResult<SaveMyProfileV1.Types.Response>> SendAsync(SaveMyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51644C0 Offset: 0x51604C0 VA: 0x51644C0
	public static APIResult<SaveMyProfileV1.Types.Response> SendWithAuthorize(SaveMyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516455C Offset: 0x516055C VA: 0x516455C
	public static Task<APIResult<SaveMyProfileV1.Types.Response>> SendWithAuthorizeAsync(SaveMyProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PlayerResources // TypeDefIndex: 2429
{
	// Methods

	// RVA: 0x5164A2C Offset: 0x5160A2C VA: 0x5164A2C
	public static APIResult<PlayerResourcesSyncV1.Types.Response> Send(PlayerResourcesSyncV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164AC8 Offset: 0x5160AC8 VA: 0x5164AC8
	public static Task<APIResult<PlayerResourcesSyncV1.Types.Response>> SendAsync(PlayerResourcesSyncV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164BBC Offset: 0x5160BBC VA: 0x5164BBC
	public static APIResult<PlayerResourcesSyncV1.Types.Response> SendWithAuthorize(PlayerResourcesSyncV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164C58 Offset: 0x5160C58 VA: 0x5164C58
	public static Task<APIResult<PlayerResourcesSyncV1.Types.Response>> SendWithAuthorizeAsync(PlayerResourcesSyncV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164D04 Offset: 0x5160D04 VA: 0x5164D04
	public static APIResult<PlayerResourcesGetNewEmblemArrivalV1.Types.Response> Send(PlayerResourcesGetNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164DA0 Offset: 0x5160DA0 VA: 0x5164DA0
	public static Task<APIResult<PlayerResourcesGetNewEmblemArrivalV1.Types.Response>> SendAsync(PlayerResourcesGetNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164E94 Offset: 0x5160E94 VA: 0x5164E94
	public static APIResult<PlayerResourcesGetNewEmblemArrivalV1.Types.Response> SendWithAuthorize(PlayerResourcesGetNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164F30 Offset: 0x5160F30 VA: 0x5164F30
	public static Task<APIResult<PlayerResourcesGetNewEmblemArrivalV1.Types.Response>> SendWithAuthorizeAsync(PlayerResourcesGetNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5164FDC Offset: 0x5160FDC VA: 0x5164FDC
	public static APIResult<PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Response> Send(PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165078 Offset: 0x5161078 VA: 0x5165078
	public static Task<APIResult<PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Response>> SendAsync(PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516516C Offset: 0x516116C VA: 0x516516C
	public static APIResult<PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Response> SendWithAuthorize(PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165208 Offset: 0x5161208 VA: 0x5165208
	public static Task<APIResult<PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Response>> SendWithAuthorizeAsync(PlayerResourcesMarkAsViewedNewEmblemArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PlayerSettings // TypeDefIndex: 2432
{
	// Methods

	// RVA: 0x51656D8 Offset: 0x51616D8 VA: 0x51656D8
	public static APIResult<PlayerSettingGetInfoV1.Types.Response> Send(PlayerSettingGetInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165774 Offset: 0x5161774 VA: 0x5165774
	public static Task<APIResult<PlayerSettingGetInfoV1.Types.Response>> SendAsync(PlayerSettingGetInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165868 Offset: 0x5161868 VA: 0x5165868
	public static APIResult<PlayerSettingGetInfoV1.Types.Response> SendWithAuthorize(PlayerSettingGetInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165904 Offset: 0x5161904 VA: 0x5165904
	public static Task<APIResult<PlayerSettingGetInfoV1.Types.Response>> SendWithAuthorizeAsync(PlayerSettingGetInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51659B0 Offset: 0x51619B0 VA: 0x51659B0
	public static APIResult<PlayerSettingSaveInfoV1.Types.Response> Send(PlayerSettingSaveInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165A4C Offset: 0x5161A4C VA: 0x5165A4C
	public static Task<APIResult<PlayerSettingSaveInfoV1.Types.Response>> SendAsync(PlayerSettingSaveInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165B40 Offset: 0x5161B40 VA: 0x5165B40
	public static APIResult<PlayerSettingSaveInfoV1.Types.Response> SendWithAuthorize(PlayerSettingSaveInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165BDC Offset: 0x5161BDC VA: 0x5165BDC
	public static Task<APIResult<PlayerSettingSaveInfoV1.Types.Response>> SendWithAuthorizeAsync(PlayerSettingSaveInfoV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PlayerStorage // TypeDefIndex: 2435
{
	// Methods

	// RVA: 0x5165F48 Offset: 0x5161F48 VA: 0x5165F48
	public static APIResult<PlayerStorageSetEntriesV1.Types.Response> Send(PlayerStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5165FE4 Offset: 0x5161FE4 VA: 0x5165FE4
	public static Task<APIResult<PlayerStorageSetEntriesV1.Types.Response>> SendAsync(PlayerStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51660D8 Offset: 0x51620D8 VA: 0x51660D8
	public static APIResult<PlayerStorageSetEntriesV1.Types.Response> SendWithAuthorize(PlayerStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166174 Offset: 0x5162174 VA: 0x5166174
	public static Task<APIResult<PlayerStorageSetEntriesV1.Types.Response>> SendWithAuthorizeAsync(PlayerStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166220 Offset: 0x5162220 VA: 0x5166220
	public static APIResult<PlayerStorageGetEntriesV1.Types.Response> Send(PlayerStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51662BC Offset: 0x51622BC VA: 0x51662BC
	public static Task<APIResult<PlayerStorageGetEntriesV1.Types.Response>> SendAsync(PlayerStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51663B0 Offset: 0x51623B0 VA: 0x51663B0
	public static APIResult<PlayerStorageGetEntriesV1.Types.Response> SendWithAuthorize(PlayerStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516644C Offset: 0x516244C VA: 0x516644C
	public static Task<APIResult<PlayerStorageGetEntriesV1.Types.Response>> SendWithAuthorizeAsync(PlayerStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PresentBox // TypeDefIndex: 2441
{
	// Methods

	// RVA: 0x51667B8 Offset: 0x51627B8 VA: 0x51667B8
	public static APIResult<PresentBoxListV1.Types.Response> Send(PresentBoxListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166854 Offset: 0x5162854 VA: 0x5166854
	public static Task<APIResult<PresentBoxListV1.Types.Response>> SendAsync(PresentBoxListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166948 Offset: 0x5162948 VA: 0x5166948
	public static APIResult<PresentBoxListV1.Types.Response> SendWithAuthorize(PresentBoxListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51669E4 Offset: 0x51629E4 VA: 0x51669E4
	public static Task<APIResult<PresentBoxListV1.Types.Response>> SendWithAuthorizeAsync(PresentBoxListV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166A90 Offset: 0x5162A90 VA: 0x5166A90
	public static APIResult<PresentBoxListHistoriesV1.Types.Response> Send(PresentBoxListHistoriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166B2C Offset: 0x5162B2C VA: 0x5166B2C
	public static Task<APIResult<PresentBoxListHistoriesV1.Types.Response>> SendAsync(PresentBoxListHistoriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166C20 Offset: 0x5162C20 VA: 0x5166C20
	public static APIResult<PresentBoxListHistoriesV1.Types.Response> SendWithAuthorize(PresentBoxListHistoriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166CBC Offset: 0x5162CBC VA: 0x5166CBC
	public static Task<APIResult<PresentBoxListHistoriesV1.Types.Response>> SendWithAuthorizeAsync(PresentBoxListHistoriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166D68 Offset: 0x5162D68 VA: 0x5166D68
	public static APIResult<PresentBoxReceiveV1.Types.Response> Send(PresentBoxReceiveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166E04 Offset: 0x5162E04 VA: 0x5166E04
	public static Task<APIResult<PresentBoxReceiveV1.Types.Response>> SendAsync(PresentBoxReceiveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166EF8 Offset: 0x5162EF8 VA: 0x5166EF8
	public static APIResult<PresentBoxReceiveV1.Types.Response> SendWithAuthorize(PresentBoxReceiveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5166F94 Offset: 0x5162F94 VA: 0x5166F94
	public static Task<APIResult<PresentBoxReceiveV1.Types.Response>> SendWithAuthorizeAsync(PresentBoxReceiveV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167040 Offset: 0x5163040 VA: 0x5167040
	public static APIResult<PresentBoxGetNewArrivalV1.Types.Response> Send(PresentBoxGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51670DC Offset: 0x51630DC VA: 0x51670DC
	public static Task<APIResult<PresentBoxGetNewArrivalV1.Types.Response>> SendAsync(PresentBoxGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51671D0 Offset: 0x51631D0 VA: 0x51671D0
	public static APIResult<PresentBoxGetNewArrivalV1.Types.Response> SendWithAuthorize(PresentBoxGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516726C Offset: 0x516326C VA: 0x516726C
	public static Task<APIResult<PresentBoxGetNewArrivalV1.Types.Response>> SendWithAuthorizeAsync(PresentBoxGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167318 Offset: 0x5163318 VA: 0x5167318
	public static APIResult<PresentBoxMarkAsViewedV1.Types.Response> Send(PresentBoxMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51673B4 Offset: 0x51633B4 VA: 0x51673B4
	public static Task<APIResult<PresentBoxMarkAsViewedV1.Types.Response>> SendAsync(PresentBoxMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51674A8 Offset: 0x51634A8 VA: 0x51674A8
	public static APIResult<PresentBoxMarkAsViewedV1.Types.Response> SendWithAuthorize(PresentBoxMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167544 Offset: 0x5163544 VA: 0x5167544
	public static Task<APIResult<PresentBoxMarkAsViewedV1.Types.Response>> SendWithAuthorizeAsync(PresentBoxMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PvpCasual // TypeDefIndex: 2448
{
	// Methods

	// RVA: 0x5167CDC Offset: 0x5163CDC VA: 0x5167CDC
	public static APIResult<PvpCasualRequestPublicMatchingV2.Types.Response> Send(PvpCasualRequestPublicMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167D78 Offset: 0x5163D78 VA: 0x5167D78
	public static Task<APIResult<PvpCasualRequestPublicMatchingV2.Types.Response>> SendAsync(PvpCasualRequestPublicMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167E6C Offset: 0x5163E6C VA: 0x5167E6C
	public static APIResult<PvpCasualRequestPublicMatchingV2.Types.Response> SendWithAuthorize(PvpCasualRequestPublicMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167F08 Offset: 0x5163F08 VA: 0x5167F08
	public static Task<APIResult<PvpCasualRequestPublicMatchingV2.Types.Response>> SendWithAuthorizeAsync(PvpCasualRequestPublicMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5167FB4 Offset: 0x5163FB4 VA: 0x5167FB4
	public static APIResult<PvpCasualRequestPrivateMatchingV2.Types.Response> Send(PvpCasualRequestPrivateMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168050 Offset: 0x5164050 VA: 0x5168050
	public static Task<APIResult<PvpCasualRequestPrivateMatchingV2.Types.Response>> SendAsync(PvpCasualRequestPrivateMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168144 Offset: 0x5164144 VA: 0x5168144
	public static APIResult<PvpCasualRequestPrivateMatchingV2.Types.Response> SendWithAuthorize(PvpCasualRequestPrivateMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51681E0 Offset: 0x51641E0 VA: 0x51681E0
	public static Task<APIResult<PvpCasualRequestPrivateMatchingV2.Types.Response>> SendWithAuthorizeAsync(PvpCasualRequestPrivateMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516828C Offset: 0x516428C VA: 0x516828C
	public static APIResult<PvpCasualDeleteMatchingV2.Types.Response> Send(PvpCasualDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168328 Offset: 0x5164328 VA: 0x5168328
	public static Task<APIResult<PvpCasualDeleteMatchingV2.Types.Response>> SendAsync(PvpCasualDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516841C Offset: 0x516441C VA: 0x516841C
	public static APIResult<PvpCasualDeleteMatchingV2.Types.Response> SendWithAuthorize(PvpCasualDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51684B8 Offset: 0x51644B8 VA: 0x51684B8
	public static Task<APIResult<PvpCasualDeleteMatchingV2.Types.Response>> SendWithAuthorizeAsync(PvpCasualDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168564 Offset: 0x5164564 VA: 0x5168564
	public static APIResult<PvpCasualGetMatchingResultV2.Types.Response> Send(PvpCasualGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168600 Offset: 0x5164600 VA: 0x5168600
	public static Task<APIResult<PvpCasualGetMatchingResultV2.Types.Response>> SendAsync(PvpCasualGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51686F4 Offset: 0x51646F4 VA: 0x51686F4
	public static APIResult<PvpCasualGetMatchingResultV2.Types.Response> SendWithAuthorize(PvpCasualGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168790 Offset: 0x5164790 VA: 0x5168790
	public static Task<APIResult<PvpCasualGetMatchingResultV2.Types.Response>> SendWithAuthorizeAsync(PvpCasualGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516883C Offset: 0x516483C VA: 0x516883C
	public static APIResult<PvpCasualStartBattleV2.Types.Response> Send(PvpCasualStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51688D8 Offset: 0x51648D8 VA: 0x51688D8
	public static Task<APIResult<PvpCasualStartBattleV2.Types.Response>> SendAsync(PvpCasualStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51689CC Offset: 0x51649CC VA: 0x51689CC
	public static APIResult<PvpCasualStartBattleV2.Types.Response> SendWithAuthorize(PvpCasualStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168A68 Offset: 0x5164A68 VA: 0x5168A68
	public static Task<APIResult<PvpCasualStartBattleV2.Types.Response>> SendWithAuthorizeAsync(PvpCasualStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168B14 Offset: 0x5164B14 VA: 0x5168B14
	public static APIResult<PvpCasualFinishBattleV1.Types.Response> Send(PvpCasualFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168BB0 Offset: 0x5164BB0 VA: 0x5168BB0
	public static Task<APIResult<PvpCasualFinishBattleV1.Types.Response>> SendAsync(PvpCasualFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168CA4 Offset: 0x5164CA4 VA: 0x5168CA4
	public static APIResult<PvpCasualFinishBattleV1.Types.Response> SendWithAuthorize(PvpCasualFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5168D40 Offset: 0x5164D40 VA: 0x5168D40
	public static Task<APIResult<PvpCasualFinishBattleV1.Types.Response>> SendWithAuthorizeAsync(PvpCasualFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PvpEvent // TypeDefIndex: 2455
{
	// Methods

	// RVA: 0x516963C Offset: 0x516563C VA: 0x516963C
	public static APIResult<PvpEventRequestEmblemMatchingV2.Types.Response> Send(PvpEventRequestEmblemMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51696D8 Offset: 0x51656D8 VA: 0x51696D8
	public static Task<APIResult<PvpEventRequestEmblemMatchingV2.Types.Response>> SendAsync(PvpEventRequestEmblemMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51697CC Offset: 0x51657CC VA: 0x51697CC
	public static APIResult<PvpEventRequestEmblemMatchingV2.Types.Response> SendWithAuthorize(PvpEventRequestEmblemMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169868 Offset: 0x5165868 VA: 0x5169868
	public static Task<APIResult<PvpEventRequestEmblemMatchingV2.Types.Response>> SendWithAuthorizeAsync(PvpEventRequestEmblemMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169914 Offset: 0x5165914 VA: 0x5169914
	public static APIResult<PvpEventDeleteMatchingV2.Types.Response> Send(PvpEventDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51699B0 Offset: 0x51659B0 VA: 0x51699B0
	public static Task<APIResult<PvpEventDeleteMatchingV2.Types.Response>> SendAsync(PvpEventDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169AA4 Offset: 0x5165AA4 VA: 0x5169AA4
	public static APIResult<PvpEventDeleteMatchingV2.Types.Response> SendWithAuthorize(PvpEventDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169B40 Offset: 0x5165B40 VA: 0x5169B40
	public static Task<APIResult<PvpEventDeleteMatchingV2.Types.Response>> SendWithAuthorizeAsync(PvpEventDeleteMatchingV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169BEC Offset: 0x5165BEC VA: 0x5169BEC
	public static APIResult<PvpEventGetMatchingResultV2.Types.Response> Send(PvpEventGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169C88 Offset: 0x5165C88 VA: 0x5169C88
	public static Task<APIResult<PvpEventGetMatchingResultV2.Types.Response>> SendAsync(PvpEventGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169D7C Offset: 0x5165D7C VA: 0x5169D7C
	public static APIResult<PvpEventGetMatchingResultV2.Types.Response> SendWithAuthorize(PvpEventGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169E18 Offset: 0x5165E18 VA: 0x5169E18
	public static Task<APIResult<PvpEventGetMatchingResultV2.Types.Response>> SendWithAuthorizeAsync(PvpEventGetMatchingResultV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169EC4 Offset: 0x5165EC4 VA: 0x5169EC4
	public static APIResult<PvpEventStartBattleV2.Types.Response> Send(PvpEventStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5169F60 Offset: 0x5165F60 VA: 0x5169F60
	public static Task<APIResult<PvpEventStartBattleV2.Types.Response>> SendAsync(PvpEventStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A054 Offset: 0x5166054 VA: 0x516A054
	public static APIResult<PvpEventStartBattleV2.Types.Response> SendWithAuthorize(PvpEventStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A0F0 Offset: 0x51660F0 VA: 0x516A0F0
	public static Task<APIResult<PvpEventStartBattleV2.Types.Response>> SendWithAuthorizeAsync(PvpEventStartBattleV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A19C Offset: 0x516619C VA: 0x516A19C
	public static APIResult<PvpEventFinishBattleV1.Types.Response> Send(PvpEventFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A238 Offset: 0x5166238 VA: 0x516A238
	public static Task<APIResult<PvpEventFinishBattleV1.Types.Response>> SendAsync(PvpEventFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A32C Offset: 0x516632C VA: 0x516A32C
	public static APIResult<PvpEventFinishBattleV1.Types.Response> SendWithAuthorize(PvpEventFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A3C8 Offset: 0x51663C8 VA: 0x516A3C8
	public static Task<APIResult<PvpEventFinishBattleV1.Types.Response>> SendWithAuthorizeAsync(PvpEventFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A474 Offset: 0x5166474 VA: 0x516A474
	public static APIResult<PvpEventGetEmblemProfileV1.Types.Response> Send(PvpEventGetEmblemProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A510 Offset: 0x5166510 VA: 0x516A510
	public static Task<APIResult<PvpEventGetEmblemProfileV1.Types.Response>> SendAsync(PvpEventGetEmblemProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A604 Offset: 0x5166604 VA: 0x516A604
	public static APIResult<PvpEventGetEmblemProfileV1.Types.Response> SendWithAuthorize(PvpEventGetEmblemProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516A6A0 Offset: 0x51666A0 VA: 0x516A6A0
	public static Task<APIResult<PvpEventGetEmblemProfileV1.Types.Response>> SendWithAuthorizeAsync(PvpEventGetEmblemProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class PvpRank // TypeDefIndex: 2467
{
	// Methods

	// RVA: 0x516AF9C Offset: 0x5166F9C VA: 0x516AF9C
	public static APIResult<PvpRankRequestMatchingV1.Types.Response> Send(PvpRankRequestMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B038 Offset: 0x5167038 VA: 0x516B038
	public static Task<APIResult<PvpRankRequestMatchingV1.Types.Response>> SendAsync(PvpRankRequestMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B12C Offset: 0x516712C VA: 0x516B12C
	public static APIResult<PvpRankRequestMatchingV1.Types.Response> SendWithAuthorize(PvpRankRequestMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B1C8 Offset: 0x51671C8 VA: 0x516B1C8
	public static Task<APIResult<PvpRankRequestMatchingV1.Types.Response>> SendWithAuthorizeAsync(PvpRankRequestMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B274 Offset: 0x5167274 VA: 0x516B274
	public static APIResult<PvpRankDeleteMatchingV1.Types.Response> Send(PvpRankDeleteMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B310 Offset: 0x5167310 VA: 0x516B310
	public static Task<APIResult<PvpRankDeleteMatchingV1.Types.Response>> SendAsync(PvpRankDeleteMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B404 Offset: 0x5167404 VA: 0x516B404
	public static APIResult<PvpRankDeleteMatchingV1.Types.Response> SendWithAuthorize(PvpRankDeleteMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B4A0 Offset: 0x51674A0 VA: 0x516B4A0
	public static Task<APIResult<PvpRankDeleteMatchingV1.Types.Response>> SendWithAuthorizeAsync(PvpRankDeleteMatchingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B54C Offset: 0x516754C VA: 0x516B54C
	public static APIResult<PvpRankGetMatchingResultV1.Types.Response> Send(PvpRankGetMatchingResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B5E8 Offset: 0x51675E8 VA: 0x516B5E8
	public static Task<APIResult<PvpRankGetMatchingResultV1.Types.Response>> SendAsync(PvpRankGetMatchingResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B6DC Offset: 0x51676DC VA: 0x516B6DC
	public static APIResult<PvpRankGetMatchingResultV1.Types.Response> SendWithAuthorize(PvpRankGetMatchingResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B778 Offset: 0x5167778 VA: 0x516B778
	public static Task<APIResult<PvpRankGetMatchingResultV1.Types.Response>> SendWithAuthorizeAsync(PvpRankGetMatchingResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B824 Offset: 0x5167824 VA: 0x516B824
	public static APIResult<PvpRankStartBattleV1.Types.Response> Send(PvpRankStartBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B8C0 Offset: 0x51678C0 VA: 0x516B8C0
	public static Task<APIResult<PvpRankStartBattleV1.Types.Response>> SendAsync(PvpRankStartBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516B9B4 Offset: 0x51679B4 VA: 0x516B9B4
	public static APIResult<PvpRankStartBattleV1.Types.Response> SendWithAuthorize(PvpRankStartBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BA50 Offset: 0x5167A50 VA: 0x516BA50
	public static Task<APIResult<PvpRankStartBattleV1.Types.Response>> SendWithAuthorizeAsync(PvpRankStartBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BAFC Offset: 0x5167AFC VA: 0x516BAFC
	public static APIResult<PvpRankFinishBattleV1.Types.Response> Send(PvpRankFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BB98 Offset: 0x5167B98 VA: 0x516BB98
	public static Task<APIResult<PvpRankFinishBattleV1.Types.Response>> SendAsync(PvpRankFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BC8C Offset: 0x5167C8C VA: 0x516BC8C
	public static APIResult<PvpRankFinishBattleV1.Types.Response> SendWithAuthorize(PvpRankFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BD28 Offset: 0x5167D28 VA: 0x516BD28
	public static Task<APIResult<PvpRankFinishBattleV1.Types.Response>> SendWithAuthorizeAsync(PvpRankFinishBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BDD4 Offset: 0x5167DD4 VA: 0x516BDD4
	public static APIResult<PvpRankDeclareLossV1.Types.Response> Send(PvpRankDeclareLossV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BE70 Offset: 0x5167E70 VA: 0x516BE70
	public static Task<APIResult<PvpRankDeclareLossV1.Types.Response>> SendAsync(PvpRankDeclareLossV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516BF64 Offset: 0x5167F64 VA: 0x516BF64
	public static APIResult<PvpRankDeclareLossV1.Types.Response> SendWithAuthorize(PvpRankDeclareLossV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C000 Offset: 0x5168000 VA: 0x516C000
	public static Task<APIResult<PvpRankDeclareLossV1.Types.Response>> SendWithAuthorizeAsync(PvpRankDeclareLossV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C0AC Offset: 0x51680AC VA: 0x516C0AC
	public static APIResult<PvpRankGetCurrentSeasonProfileV1.Types.Response> Send(PvpRankGetCurrentSeasonProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C148 Offset: 0x5168148 VA: 0x516C148
	public static Task<APIResult<PvpRankGetCurrentSeasonProfileV1.Types.Response>> SendAsync(PvpRankGetCurrentSeasonProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C23C Offset: 0x516823C VA: 0x516C23C
	public static APIResult<PvpRankGetCurrentSeasonProfileV1.Types.Response> SendWithAuthorize(PvpRankGetCurrentSeasonProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C2D8 Offset: 0x51682D8 VA: 0x516C2D8
	public static Task<APIResult<PvpRankGetCurrentSeasonProfileV1.Types.Response>> SendWithAuthorizeAsync(PvpRankGetCurrentSeasonProfileV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C384 Offset: 0x5168384 VA: 0x516C384
	public static APIResult<PvpRankGetSeasonResultV1.Types.Response> Send(PvpRankGetSeasonResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C420 Offset: 0x5168420 VA: 0x516C420
	public static Task<APIResult<PvpRankGetSeasonResultV1.Types.Response>> SendAsync(PvpRankGetSeasonResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C514 Offset: 0x5168514 VA: 0x516C514
	public static APIResult<PvpRankGetSeasonResultV1.Types.Response> SendWithAuthorize(PvpRankGetSeasonResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C5B0 Offset: 0x51685B0 VA: 0x516C5B0
	public static Task<APIResult<PvpRankGetSeasonResultV1.Types.Response>> SendWithAuthorizeAsync(PvpRankGetSeasonResultV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C65C Offset: 0x516865C VA: 0x516C65C
	public static APIResult<PvpRankListRecentBattleRecordsV1.Types.Response> Send(PvpRankListRecentBattleRecordsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C6F8 Offset: 0x51686F8 VA: 0x516C6F8
	public static Task<APIResult<PvpRankListRecentBattleRecordsV1.Types.Response>> SendAsync(PvpRankListRecentBattleRecordsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C7EC Offset: 0x51687EC VA: 0x516C7EC
	public static APIResult<PvpRankListRecentBattleRecordsV1.Types.Response> SendWithAuthorize(PvpRankListRecentBattleRecordsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C888 Offset: 0x5168888 VA: 0x516C888
	public static Task<APIResult<PvpRankListRecentBattleRecordsV1.Types.Response>> SendWithAuthorizeAsync(PvpRankListRecentBattleRecordsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C934 Offset: 0x5168934 VA: 0x516C934
	public static APIResult<PvpRankGetCurrentSeasonRankingV1.Types.Response> Send(PvpRankGetCurrentSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516C9D0 Offset: 0x51689D0 VA: 0x516C9D0
	public static Task<APIResult<PvpRankGetCurrentSeasonRankingV1.Types.Response>> SendAsync(PvpRankGetCurrentSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CAC4 Offset: 0x5168AC4 VA: 0x516CAC4
	public static APIResult<PvpRankGetCurrentSeasonRankingV1.Types.Response> SendWithAuthorize(PvpRankGetCurrentSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CB60 Offset: 0x5168B60 VA: 0x516CB60
	public static Task<APIResult<PvpRankGetCurrentSeasonRankingV1.Types.Response>> SendWithAuthorizeAsync(PvpRankGetCurrentSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CC0C Offset: 0x5168C0C VA: 0x516CC0C
	public static APIResult<PvpRankGetPastSeasonRankingV1.Types.Response> Send(PvpRankGetPastSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CCA8 Offset: 0x5168CA8 VA: 0x516CCA8
	public static Task<APIResult<PvpRankGetPastSeasonRankingV1.Types.Response>> SendAsync(PvpRankGetPastSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CD9C Offset: 0x5168D9C VA: 0x516CD9C
	public static APIResult<PvpRankGetPastSeasonRankingV1.Types.Response> SendWithAuthorize(PvpRankGetPastSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516CE38 Offset: 0x5168E38 VA: 0x516CE38
	public static Task<APIResult<PvpRankGetPastSeasonRankingV1.Types.Response>> SendWithAuthorizeAsync(PvpRankGetPastSeasonRankingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Shop // TypeDefIndex: 2471
{
	// Methods

	[Obsolete]
	// RVA: 0x516DE28 Offset: 0x5169E28 VA: 0x516DE28
	public static APIResult<ShopGetNewArrivalV1.Types.Response> Send(ShopGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x516DEC4 Offset: 0x5169EC4 VA: 0x516DEC4
	public static Task<APIResult<ShopGetNewArrivalV1.Types.Response>> SendAsync(ShopGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x516DFB8 Offset: 0x5169FB8 VA: 0x516DFB8
	public static APIResult<ShopGetNewArrivalV1.Types.Response> SendWithAuthorize(ShopGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x516E054 Offset: 0x516A054 VA: 0x516E054
	public static Task<APIResult<ShopGetNewArrivalV1.Types.Response>> SendWithAuthorizeAsync(ShopGetNewArrivalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E100 Offset: 0x516A100 VA: 0x516E100
	public static APIResult<ShopGetNewNotificationV1.Types.Response> Send(ShopGetNewNotificationV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E19C Offset: 0x516A19C VA: 0x516E19C
	public static Task<APIResult<ShopGetNewNotificationV1.Types.Response>> SendAsync(ShopGetNewNotificationV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E290 Offset: 0x516A290 VA: 0x516E290
	public static APIResult<ShopGetNewNotificationV1.Types.Response> SendWithAuthorize(ShopGetNewNotificationV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E32C Offset: 0x516A32C VA: 0x516E32C
	public static Task<APIResult<ShopGetNewNotificationV1.Types.Response>> SendWithAuthorizeAsync(ShopGetNewNotificationV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E3D8 Offset: 0x516A3D8 VA: 0x516E3D8
	public static APIResult<ShopMarkAsViewedV1.Types.Response> Send(ShopMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E474 Offset: 0x516A474 VA: 0x516E474
	public static Task<APIResult<ShopMarkAsViewedV1.Types.Response>> SendAsync(ShopMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E568 Offset: 0x516A568 VA: 0x516E568
	public static APIResult<ShopMarkAsViewedV1.Types.Response> SendWithAuthorize(ShopMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516E604 Offset: 0x516A604 VA: 0x516E604
	public static Task<APIResult<ShopMarkAsViewedV1.Types.Response>> SendWithAuthorizeAsync(ShopMarkAsViewedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class SignInWithApple // TypeDefIndex: 2473
{
	// Methods

	// RVA: 0x516EAD4 Offset: 0x516AAD4 VA: 0x516EAD4
	public static APIResult<SignInWithAppleGenerateTokenV1.Types.Response> Send(SignInWithAppleGenerateTokenV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516EB70 Offset: 0x516AB70 VA: 0x516EB70
	public static Task<APIResult<SignInWithAppleGenerateTokenV1.Types.Response>> SendAsync(SignInWithAppleGenerateTokenV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516EC64 Offset: 0x516AC64 VA: 0x516EC64
	public static APIResult<SignInWithAppleGenerateTokenV1.Types.Response> SendWithAuthorize(SignInWithAppleGenerateTokenV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516ED00 Offset: 0x516AD00 VA: 0x516ED00
	public static Task<APIResult<SignInWithAppleGenerateTokenV1.Types.Response>> SendWithAuthorizeAsync(SignInWithAppleGenerateTokenV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class SoloBattle // TypeDefIndex: 2482
{
	// Methods

	// RVA: 0x516EF0C Offset: 0x516AF0C VA: 0x516EF0C
	public static APIResult<SoloBattleGetStepupBattlesV1.Types.Response> Send(SoloBattleGetStepupBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516EFA8 Offset: 0x516AFA8 VA: 0x516EFA8
	public static Task<APIResult<SoloBattleGetStepupBattlesV1.Types.Response>> SendAsync(SoloBattleGetStepupBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F09C Offset: 0x516B09C VA: 0x516F09C
	public static APIResult<SoloBattleGetStepupBattlesV1.Types.Response> SendWithAuthorize(SoloBattleGetStepupBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F138 Offset: 0x516B138 VA: 0x516F138
	public static Task<APIResult<SoloBattleGetStepupBattlesV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleGetStepupBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F1E4 Offset: 0x516B1E4 VA: 0x516F1E4
	public static APIResult<SoloBattleStartStepupBattleV1.Types.Response> Send(SoloBattleStartStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F280 Offset: 0x516B280 VA: 0x516F280
	public static Task<APIResult<SoloBattleStartStepupBattleV1.Types.Response>> SendAsync(SoloBattleStartStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F374 Offset: 0x516B374 VA: 0x516F374
	public static APIResult<SoloBattleStartStepupBattleV1.Types.Response> SendWithAuthorize(SoloBattleStartStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F410 Offset: 0x516B410 VA: 0x516F410
	public static Task<APIResult<SoloBattleStartStepupBattleV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleStartStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F4BC Offset: 0x516B4BC VA: 0x516F4BC
	public static APIResult<SoloBattleFinishStepupBattleV1.Types.Response> Send(SoloBattleFinishStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F558 Offset: 0x516B558 VA: 0x516F558
	public static Task<APIResult<SoloBattleFinishStepupBattleV1.Types.Response>> SendAsync(SoloBattleFinishStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F64C Offset: 0x516B64C VA: 0x516F64C
	public static APIResult<SoloBattleFinishStepupBattleV1.Types.Response> SendWithAuthorize(SoloBattleFinishStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F6E8 Offset: 0x516B6E8 VA: 0x516F6E8
	public static Task<APIResult<SoloBattleFinishStepupBattleV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleFinishStepupBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F794 Offset: 0x516B794 VA: 0x516F794
	public static APIResult<SoloBattleGetEventBattlesV1.Types.Response> Send(SoloBattleGetEventBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F830 Offset: 0x516B830 VA: 0x516F830
	public static Task<APIResult<SoloBattleGetEventBattlesV1.Types.Response>> SendAsync(SoloBattleGetEventBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F924 Offset: 0x516B924 VA: 0x516F924
	public static APIResult<SoloBattleGetEventBattlesV1.Types.Response> SendWithAuthorize(SoloBattleGetEventBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516F9C0 Offset: 0x516B9C0 VA: 0x516F9C0
	public static Task<APIResult<SoloBattleGetEventBattlesV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleGetEventBattlesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FA6C Offset: 0x516BA6C VA: 0x516FA6C
	public static APIResult<SoloBattleStartEventBattleV1.Types.Response> Send(SoloBattleStartEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FB08 Offset: 0x516BB08 VA: 0x516FB08
	public static Task<APIResult<SoloBattleStartEventBattleV1.Types.Response>> SendAsync(SoloBattleStartEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FBFC Offset: 0x516BBFC VA: 0x516FBFC
	public static APIResult<SoloBattleStartEventBattleV1.Types.Response> SendWithAuthorize(SoloBattleStartEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FC98 Offset: 0x516BC98 VA: 0x516FC98
	public static Task<APIResult<SoloBattleStartEventBattleV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleStartEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FD44 Offset: 0x516BD44 VA: 0x516FD44
	public static APIResult<SoloBattleFinishEventBattleV1.Types.Response> Send(SoloBattleFinishEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FDE0 Offset: 0x516BDE0 VA: 0x516FDE0
	public static Task<APIResult<SoloBattleFinishEventBattleV1.Types.Response>> SendAsync(SoloBattleFinishEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FED4 Offset: 0x516BED4 VA: 0x516FED4
	public static APIResult<SoloBattleFinishEventBattleV1.Types.Response> SendWithAuthorize(SoloBattleFinishEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x516FF70 Offset: 0x516BF70 VA: 0x516FF70
	public static Task<APIResult<SoloBattleFinishEventBattleV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleFinishEventBattleV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517001C Offset: 0x516C01C VA: 0x517001C
	public static APIResult<SoloBattleHealEventPowerV1.Types.Response> Send(SoloBattleHealEventPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51700B8 Offset: 0x516C0B8 VA: 0x51700B8
	public static Task<APIResult<SoloBattleHealEventPowerV1.Types.Response>> SendAsync(SoloBattleHealEventPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51701AC Offset: 0x516C1AC VA: 0x51701AC
	public static APIResult<SoloBattleHealEventPowerV1.Types.Response> SendWithAuthorize(SoloBattleHealEventPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5170248 Offset: 0x516C248 VA: 0x5170248
	public static Task<APIResult<SoloBattleHealEventPowerV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleHealEventPowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51702F4 Offset: 0x516C2F4 VA: 0x51702F4
	public static APIResult<SoloBattleGetEventPowersV1.Types.Response> Send(SoloBattleGetEventPowersV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5170390 Offset: 0x516C390 VA: 0x5170390
	public static Task<APIResult<SoloBattleGetEventPowersV1.Types.Response>> SendAsync(SoloBattleGetEventPowersV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5170484 Offset: 0x516C484 VA: 0x5170484
	public static APIResult<SoloBattleGetEventPowersV1.Types.Response> SendWithAuthorize(SoloBattleGetEventPowersV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5170520 Offset: 0x516C520 VA: 0x5170520
	public static Task<APIResult<SoloBattleGetEventPowersV1.Types.Response>> SendWithAuthorizeAsync(SoloBattleGetEventPowersV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class System // TypeDefIndex: 2486
{
	// Methods

	// RVA: 0x51710E4 Offset: 0x516D0E4 VA: 0x51710E4
	public static APIResult<SystemAuthorizeV1.Types.Response> Send(SystemAuthorizeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171180 Offset: 0x516D180 VA: 0x5171180
	public static Task<APIResult<SystemAuthorizeV1.Types.Response>> SendAsync(SystemAuthorizeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171274 Offset: 0x516D274 VA: 0x5171274
	public static APIResult<SystemAuthorizeV1.Types.Response> SendWithAuthorize(SystemAuthorizeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171310 Offset: 0x516D310 VA: 0x5171310
	public static Task<APIResult<SystemAuthorizeV1.Types.Response>> SendWithAuthorizeAsync(SystemAuthorizeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51713BC Offset: 0x516D3BC VA: 0x51713BC
	public static APIResult<SystemLoginV1.Types.Response> Send(SystemLoginV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171458 Offset: 0x516D458 VA: 0x5171458
	public static Task<APIResult<SystemLoginV1.Types.Response>> SendAsync(SystemLoginV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517154C Offset: 0x516D54C VA: 0x517154C
	public static APIResult<SystemLoginV1.Types.Response> SendWithAuthorize(SystemLoginV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51715E8 Offset: 0x516D5E8 VA: 0x51715E8
	public static Task<APIResult<SystemLoginV1.Types.Response>> SendWithAuthorizeAsync(SystemLoginV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171694 Offset: 0x516D694 VA: 0x5171694
	public static APIResult<SystemPartialMaintenanceV1.Types.Response> Send(SystemPartialMaintenanceV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171730 Offset: 0x516D730 VA: 0x5171730
	public static Task<APIResult<SystemPartialMaintenanceV1.Types.Response>> SendAsync(SystemPartialMaintenanceV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171824 Offset: 0x516D824 VA: 0x5171824
	public static APIResult<SystemPartialMaintenanceV1.Types.Response> SendWithAuthorize(SystemPartialMaintenanceV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51718C0 Offset: 0x516D8C0 VA: 0x51718C0
	public static Task<APIResult<SystemPartialMaintenanceV1.Types.Response>> SendWithAuthorizeAsync(SystemPartialMaintenanceV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class ThankReward // TypeDefIndex: 2489
{
	// Methods

	// RVA: 0x5171D90 Offset: 0x516DD90 VA: 0x5171D90
	public static APIResult<ThankRewardSendV1.Types.Response> Send(ThankRewardSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171E2C Offset: 0x516DE2C VA: 0x5171E2C
	public static Task<APIResult<ThankRewardSendV1.Types.Response>> SendAsync(ThankRewardSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171F20 Offset: 0x516DF20 VA: 0x5171F20
	public static APIResult<ThankRewardSendV1.Types.Response> SendWithAuthorize(ThankRewardSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5171FBC Offset: 0x516DFBC VA: 0x5171FBC
	public static Task<APIResult<ThankRewardSendV1.Types.Response>> SendWithAuthorizeAsync(ThankRewardSendV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172068 Offset: 0x516E068 VA: 0x5172068
	public static APIResult<ThankRewardSendToBotV1.Types.Response> Send(ThankRewardSendToBotV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172104 Offset: 0x516E104 VA: 0x5172104
	public static Task<APIResult<ThankRewardSendToBotV1.Types.Response>> SendAsync(ThankRewardSendToBotV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51721F8 Offset: 0x516E1F8 VA: 0x51721F8
	public static APIResult<ThankRewardSendToBotV1.Types.Response> SendWithAuthorize(ThankRewardSendToBotV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172294 Offset: 0x516E294 VA: 0x5172294
	public static Task<APIResult<ThankRewardSendToBotV1.Types.Response>> SendWithAuthorizeAsync(ThankRewardSendToBotV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Trade // TypeDefIndex: 2505
{
	// Methods

	// RVA: 0x5172600 Offset: 0x516E600 VA: 0x5172600
	public static APIResult<TradeGetV1.Types.Response> Send(TradeGetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517269C Offset: 0x516E69C VA: 0x517269C
	public static Task<APIResult<TradeGetV1.Types.Response>> SendAsync(TradeGetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172790 Offset: 0x516E790 VA: 0x5172790
	public static APIResult<TradeGetV1.Types.Response> SendWithAuthorize(TradeGetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517282C Offset: 0x516E82C VA: 0x517282C
	public static Task<APIResult<TradeGetV1.Types.Response>> SendWithAuthorizeAsync(TradeGetV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x51728D8 Offset: 0x516E8D8 VA: 0x51728D8
	public static APIResult<TradeSubmitProposalV1.Types.Response> Send(TradeSubmitProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172974 Offset: 0x516E974 VA: 0x5172974
	public static Task<APIResult<TradeSubmitProposalV1.Types.Response>> SendAsync(TradeSubmitProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172A68 Offset: 0x516EA68 VA: 0x5172A68
	public static APIResult<TradeSubmitProposalV1.Types.Response> SendWithAuthorize(TradeSubmitProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172B04 Offset: 0x516EB04 VA: 0x5172B04
	public static Task<APIResult<TradeSubmitProposalV1.Types.Response>> SendWithAuthorizeAsync(TradeSubmitProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172BB0 Offset: 0x516EBB0 VA: 0x5172BB0
	public static APIResult<TradeAcceptProposalV1.Types.Response> Send(TradeAcceptProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172C4C Offset: 0x516EC4C VA: 0x5172C4C
	public static Task<APIResult<TradeAcceptProposalV1.Types.Response>> SendAsync(TradeAcceptProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172D40 Offset: 0x516ED40 VA: 0x5172D40
	public static APIResult<TradeAcceptProposalV1.Types.Response> SendWithAuthorize(TradeAcceptProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	[Obsolete]
	// RVA: 0x5172DDC Offset: 0x516EDDC VA: 0x5172DDC
	public static Task<APIResult<TradeAcceptProposalV1.Types.Response>> SendWithAuthorizeAsync(TradeAcceptProposalV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172E88 Offset: 0x516EE88 VA: 0x5172E88
	public static APIResult<TradeSubmitProposalV2.Types.Response> Send(TradeSubmitProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5172F24 Offset: 0x516EF24 VA: 0x5172F24
	public static Task<APIResult<TradeSubmitProposalV2.Types.Response>> SendAsync(TradeSubmitProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173018 Offset: 0x516F018 VA: 0x5173018
	public static APIResult<TradeSubmitProposalV2.Types.Response> SendWithAuthorize(TradeSubmitProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51730B4 Offset: 0x516F0B4 VA: 0x51730B4
	public static Task<APIResult<TradeSubmitProposalV2.Types.Response>> SendWithAuthorizeAsync(TradeSubmitProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173160 Offset: 0x516F160 VA: 0x5173160
	public static APIResult<TradeAcceptProposalV2.Types.Response> Send(TradeAcceptProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51731FC Offset: 0x516F1FC VA: 0x51731FC
	public static Task<APIResult<TradeAcceptProposalV2.Types.Response>> SendAsync(TradeAcceptProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51732F0 Offset: 0x516F2F0 VA: 0x51732F0
	public static APIResult<TradeAcceptProposalV2.Types.Response> SendWithAuthorize(TradeAcceptProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517338C Offset: 0x516F38C VA: 0x517338C
	public static Task<APIResult<TradeAcceptProposalV2.Types.Response>> SendWithAuthorizeAsync(TradeAcceptProposalV2.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173438 Offset: 0x516F438 VA: 0x5173438
	public static APIResult<TradeConfirmV1.Types.Response> Send(TradeConfirmV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51734D4 Offset: 0x516F4D4 VA: 0x51734D4
	public static Task<APIResult<TradeConfirmV1.Types.Response>> SendAsync(TradeConfirmV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51735C8 Offset: 0x516F5C8 VA: 0x51735C8
	public static APIResult<TradeConfirmV1.Types.Response> SendWithAuthorize(TradeConfirmV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173664 Offset: 0x516F664 VA: 0x5173664
	public static Task<APIResult<TradeConfirmV1.Types.Response>> SendWithAuthorizeAsync(TradeConfirmV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173710 Offset: 0x516F710 VA: 0x5173710
	public static APIResult<TradeRejectV1.Types.Response> Send(TradeRejectV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51737AC Offset: 0x516F7AC VA: 0x51737AC
	public static Task<APIResult<TradeRejectV1.Types.Response>> SendAsync(TradeRejectV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51738A0 Offset: 0x516F8A0 VA: 0x51738A0
	public static APIResult<TradeRejectV1.Types.Response> SendWithAuthorize(TradeRejectV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517393C Offset: 0x516F93C VA: 0x517393C
	public static Task<APIResult<TradeRejectV1.Types.Response>> SendWithAuthorizeAsync(TradeRejectV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51739E8 Offset: 0x516F9E8 VA: 0x51739E8
	public static APIResult<TradeReceiveOutcomesV1.Types.Response> Send(TradeReceiveOutcomesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173A84 Offset: 0x516FA84 VA: 0x5173A84
	public static Task<APIResult<TradeReceiveOutcomesV1.Types.Response>> SendAsync(TradeReceiveOutcomesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173B78 Offset: 0x516FB78 VA: 0x5173B78
	public static APIResult<TradeReceiveOutcomesV1.Types.Response> SendWithAuthorize(TradeReceiveOutcomesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173C14 Offset: 0x516FC14 VA: 0x5173C14
	public static Task<APIResult<TradeReceiveOutcomesV1.Types.Response>> SendWithAuthorizeAsync(TradeReceiveOutcomesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173CC0 Offset: 0x516FCC0 VA: 0x5173CC0
	public static APIResult<TradeReceiveDepositsV1.Types.Response> Send(TradeReceiveDepositsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173D5C Offset: 0x516FD5C VA: 0x5173D5C
	public static Task<APIResult<TradeReceiveDepositsV1.Types.Response>> SendAsync(TradeReceiveDepositsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173E50 Offset: 0x516FE50 VA: 0x5173E50
	public static APIResult<TradeReceiveDepositsV1.Types.Response> SendWithAuthorize(TradeReceiveDepositsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173EEC Offset: 0x516FEEC VA: 0x5173EEC
	public static Task<APIResult<TradeReceiveDepositsV1.Types.Response>> SendWithAuthorizeAsync(TradeReceiveDepositsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5173F98 Offset: 0x516FF98 VA: 0x5173F98
	public static APIResult<TradeGetFriendsV1.Types.Response> Send(TradeGetFriendsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174034 Offset: 0x5170034 VA: 0x5174034
	public static Task<APIResult<TradeGetFriendsV1.Types.Response>> SendAsync(TradeGetFriendsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174128 Offset: 0x5170128 VA: 0x5174128
	public static APIResult<TradeGetFriendsV1.Types.Response> SendWithAuthorize(TradeGetFriendsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51741C4 Offset: 0x51701C4 VA: 0x51741C4
	public static Task<APIResult<TradeGetFriendsV1.Types.Response>> SendWithAuthorizeAsync(TradeGetFriendsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174270 Offset: 0x5170270 VA: 0x5174270
	public static APIResult<TradeGetSettingV1.Types.Response> Send(TradeGetSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517430C Offset: 0x517030C VA: 0x517430C
	public static Task<APIResult<TradeGetSettingV1.Types.Response>> SendAsync(TradeGetSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174400 Offset: 0x5170400 VA: 0x5174400
	public static APIResult<TradeGetSettingV1.Types.Response> SendWithAuthorize(TradeGetSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517449C Offset: 0x517049C VA: 0x517449C
	public static Task<APIResult<TradeGetSettingV1.Types.Response>> SendWithAuthorizeAsync(TradeGetSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174548 Offset: 0x5170548 VA: 0x5174548
	public static APIResult<TradeSaveSettingV1.Types.Response> Send(TradeSaveSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51745E4 Offset: 0x51705E4 VA: 0x51745E4
	public static Task<APIResult<TradeSaveSettingV1.Types.Response>> SendAsync(TradeSaveSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51746D8 Offset: 0x51706D8 VA: 0x51746D8
	public static APIResult<TradeSaveSettingV1.Types.Response> SendWithAuthorize(TradeSaveSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174774 Offset: 0x5170774 VA: 0x5174774
	public static Task<APIResult<TradeSaveSettingV1.Types.Response>> SendWithAuthorizeAsync(TradeSaveSettingV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174820 Offset: 0x5170820 VA: 0x5174820
	public static APIResult<TradeGetHistoryV1.Types.Response> Send(TradeGetHistoryV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51748BC Offset: 0x51708BC VA: 0x51748BC
	public static Task<APIResult<TradeGetHistoryV1.Types.Response>> SendAsync(TradeGetHistoryV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51749B0 Offset: 0x51709B0 VA: 0x51749B0
	public static APIResult<TradeGetHistoryV1.Types.Response> SendWithAuthorize(TradeGetHistoryV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174A4C Offset: 0x5170A4C VA: 0x5174A4C
	public static Task<APIResult<TradeGetHistoryV1.Types.Response>> SendWithAuthorizeAsync(TradeGetHistoryV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174AF8 Offset: 0x5170AF8 VA: 0x5174AF8
	public static APIResult<TradeGetTradePowerV1.Types.Response> Send(TradeGetTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174B94 Offset: 0x5170B94 VA: 0x5174B94
	public static Task<APIResult<TradeGetTradePowerV1.Types.Response>> SendAsync(TradeGetTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174C88 Offset: 0x5170C88 VA: 0x5174C88
	public static APIResult<TradeGetTradePowerV1.Types.Response> SendWithAuthorize(TradeGetTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174D24 Offset: 0x5170D24 VA: 0x5174D24
	public static Task<APIResult<TradeGetTradePowerV1.Types.Response>> SendWithAuthorizeAsync(TradeGetTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174DD0 Offset: 0x5170DD0 VA: 0x5174DD0
	public static APIResult<TradeHealTradePowerV1.Types.Response> Send(TradeHealTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174E6C Offset: 0x5170E6C VA: 0x5174E6C
	public static Task<APIResult<TradeHealTradePowerV1.Types.Response>> SendAsync(TradeHealTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174F60 Offset: 0x5170F60 VA: 0x5174F60
	public static APIResult<TradeHealTradePowerV1.Types.Response> SendWithAuthorize(TradeHealTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5174FFC Offset: 0x5170FFC VA: 0x5174FFC
	public static Task<APIResult<TradeHealTradePowerV1.Types.Response>> SendWithAuthorizeAsync(TradeHealTradePowerV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Trophy // TypeDefIndex: 2508
{
	// Methods

	// RVA: 0x517657C Offset: 0x517257C VA: 0x517657C
	public static APIResult<TrophyCompleteV1.Types.Response> Send(TrophyCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5176618 Offset: 0x5172618 VA: 0x5176618
	public static Task<APIResult<TrophyCompleteV1.Types.Response>> SendAsync(TrophyCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517670C Offset: 0x517270C VA: 0x517670C
	public static APIResult<TrophyCompleteV1.Types.Response> SendWithAuthorize(TrophyCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51767A8 Offset: 0x51727A8 VA: 0x51767A8
	public static Task<APIResult<TrophyCompleteV1.Types.Response>> SendWithAuthorizeAsync(TrophyCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5176854 Offset: 0x5172854 VA: 0x5176854
	public static APIResult<TrophyGetStatusV1.Types.Response> Send(TrophyGetStatusV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51768F0 Offset: 0x51728F0 VA: 0x51768F0
	public static Task<APIResult<TrophyGetStatusV1.Types.Response>> SendAsync(TrophyGetStatusV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51769E4 Offset: 0x51729E4 VA: 0x51769E4
	public static APIResult<TrophyGetStatusV1.Types.Response> SendWithAuthorize(TrophyGetStatusV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5176A80 Offset: 0x5172A80 VA: 0x5176A80
	public static Task<APIResult<TrophyGetStatusV1.Types.Response>> SendWithAuthorizeAsync(TrophyGetStatusV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Tutorial // TypeDefIndex: 2514
{
	// Methods

	// RVA: 0x5176DEC Offset: 0x5172DEC VA: 0x5176DEC
	public static APIResult<TutorialCompleteV1.Types.Response> Send(TutorialCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5176E88 Offset: 0x5172E88 VA: 0x5176E88
	public static Task<APIResult<TutorialCompleteV1.Types.Response>> SendAsync(TutorialCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5176F7C Offset: 0x5172F7C VA: 0x5176F7C
	public static APIResult<TutorialCompleteV1.Types.Response> SendWithAuthorize(TutorialCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177018 Offset: 0x5173018 VA: 0x5177018
	public static Task<APIResult<TutorialCompleteV1.Types.Response>> SendWithAuthorizeAsync(TutorialCompleteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51770C4 Offset: 0x51730C4 VA: 0x51770C4
	public static APIResult<TutorialChoiceExchangeRouteV1.Types.Response> Send(TutorialChoiceExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177160 Offset: 0x5173160 VA: 0x5177160
	public static Task<APIResult<TutorialChoiceExchangeRouteV1.Types.Response>> SendAsync(TutorialChoiceExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177254 Offset: 0x5173254 VA: 0x5177254
	public static APIResult<TutorialChoiceExchangeRouteV1.Types.Response> SendWithAuthorize(TutorialChoiceExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51772F0 Offset: 0x51732F0 VA: 0x51772F0
	public static Task<APIResult<TutorialChoiceExchangeRouteV1.Types.Response>> SendWithAuthorizeAsync(TutorialChoiceExchangeRouteV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517739C Offset: 0x517339C VA: 0x517739C
	public static APIResult<TutorialPackPurchaseV1.Types.Response> Send(TutorialPackPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177438 Offset: 0x5173438 VA: 0x5177438
	public static Task<APIResult<TutorialPackPurchaseV1.Types.Response>> SendAsync(TutorialPackPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517752C Offset: 0x517352C VA: 0x517752C
	public static APIResult<TutorialPackPurchaseV1.Types.Response> SendWithAuthorize(TutorialPackPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51775C8 Offset: 0x51735C8 VA: 0x51775C8
	public static Task<APIResult<TutorialPackPurchaseV1.Types.Response>> SendWithAuthorizeAsync(TutorialPackPurchaseV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177674 Offset: 0x5173674 VA: 0x5177674
	public static APIResult<TutorialGetFeedTimelineV1.Types.Response> Send(TutorialGetFeedTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177710 Offset: 0x5173710 VA: 0x5177710
	public static Task<APIResult<TutorialGetFeedTimelineV1.Types.Response>> SendAsync(TutorialGetFeedTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177804 Offset: 0x5173804 VA: 0x5177804
	public static APIResult<TutorialGetFeedTimelineV1.Types.Response> SendWithAuthorize(TutorialGetFeedTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51778A0 Offset: 0x51738A0 VA: 0x51778A0
	public static Task<APIResult<TutorialGetFeedTimelineV1.Types.Response>> SendWithAuthorizeAsync(TutorialGetFeedTimelineV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517794C Offset: 0x517394C VA: 0x517794C
	public static APIResult<TutorialChallengeFeedV1.Types.Response> Send(TutorialChallengeFeedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51779E8 Offset: 0x51739E8 VA: 0x51779E8
	public static Task<APIResult<TutorialChallengeFeedV1.Types.Response>> SendAsync(TutorialChallengeFeedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177ADC Offset: 0x5173ADC VA: 0x5177ADC
	public static APIResult<TutorialChallengeFeedV1.Types.Response> SendWithAuthorize(TutorialChallengeFeedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5177B78 Offset: 0x5173B78 VA: 0x5177B78
	public static Task<APIResult<TutorialChallengeFeedV1.Types.Response>> SendWithAuthorizeAsync(TutorialChallengeFeedV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceServer.PlayerApi
public static class Webview // TypeDefIndex: 2525
{
	// Methods

	// RVA: 0x5178310 Offset: 0x5174310 VA: 0x5178310
	public static APIResult<WebviewGetNewsV1.Types.Response> Send(WebviewGetNewsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51783AC Offset: 0x51743AC VA: 0x51783AC
	public static Task<APIResult<WebviewGetNewsV1.Types.Response>> SendAsync(WebviewGetNewsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51784A0 Offset: 0x51744A0 VA: 0x51784A0
	public static APIResult<WebviewGetNewsV1.Types.Response> SendWithAuthorize(WebviewGetNewsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517853C Offset: 0x517453C VA: 0x517853C
	public static Task<APIResult<WebviewGetNewsV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetNewsV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51785E8 Offset: 0x51745E8 VA: 0x51785E8
	public static APIResult<WebviewGetNewsDetailUrlV1.Types.Response> Send(WebviewGetNewsDetailUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178684 Offset: 0x5174684 VA: 0x5178684
	public static Task<APIResult<WebviewGetNewsDetailUrlV1.Types.Response>> SendAsync(WebviewGetNewsDetailUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178778 Offset: 0x5174778 VA: 0x5178778
	public static APIResult<WebviewGetNewsDetailUrlV1.Types.Response> SendWithAuthorize(WebviewGetNewsDetailUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178814 Offset: 0x5174814 VA: 0x5178814
	public static Task<APIResult<WebviewGetNewsDetailUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetNewsDetailUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51788C0 Offset: 0x51748C0 VA: 0x51788C0
	public static APIResult<WebviewGetGameHintUrlV1.Types.Response> Send(WebviewGetGameHintUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517895C Offset: 0x517495C VA: 0x517895C
	public static Task<APIResult<WebviewGetGameHintUrlV1.Types.Response>> SendAsync(WebviewGetGameHintUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178A50 Offset: 0x5174A50 VA: 0x5178A50
	public static APIResult<WebviewGetGameHintUrlV1.Types.Response> SendWithAuthorize(WebviewGetGameHintUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178AEC Offset: 0x5174AEC VA: 0x5178AEC
	public static Task<APIResult<WebviewGetGameHintUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetGameHintUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178B98 Offset: 0x5174B98 VA: 0x5178B98
	public static APIResult<WebviewGetAboutUrlV1.Types.Response> Send(WebviewGetAboutUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178C34 Offset: 0x5174C34 VA: 0x5178C34
	public static Task<APIResult<WebviewGetAboutUrlV1.Types.Response>> SendAsync(WebviewGetAboutUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178D28 Offset: 0x5174D28 VA: 0x5178D28
	public static APIResult<WebviewGetAboutUrlV1.Types.Response> SendWithAuthorize(WebviewGetAboutUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178DC4 Offset: 0x5174DC4 VA: 0x5178DC4
	public static Task<APIResult<WebviewGetAboutUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetAboutUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178E70 Offset: 0x5174E70 VA: 0x5178E70
	public static APIResult<WebviewGetTermsOfServiceUrlV1.Types.Response> Send(WebviewGetTermsOfServiceUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5178F0C Offset: 0x5174F0C VA: 0x5178F0C
	public static Task<APIResult<WebviewGetTermsOfServiceUrlV1.Types.Response>> SendAsync(WebviewGetTermsOfServiceUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179000 Offset: 0x5175000 VA: 0x5179000
	public static APIResult<WebviewGetTermsOfServiceUrlV1.Types.Response> SendWithAuthorize(WebviewGetTermsOfServiceUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517909C Offset: 0x517509C VA: 0x517909C
	public static Task<APIResult<WebviewGetTermsOfServiceUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetTermsOfServiceUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179148 Offset: 0x5175148 VA: 0x5179148
	public static APIResult<WebviewGetPrivacyPolicyUrlV1.Types.Response> Send(WebviewGetPrivacyPolicyUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51791E4 Offset: 0x51751E4 VA: 0x51791E4
	public static Task<APIResult<WebviewGetPrivacyPolicyUrlV1.Types.Response>> SendAsync(WebviewGetPrivacyPolicyUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51792D8 Offset: 0x51752D8 VA: 0x51792D8
	public static APIResult<WebviewGetPrivacyPolicyUrlV1.Types.Response> SendWithAuthorize(WebviewGetPrivacyPolicyUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179374 Offset: 0x5175374 VA: 0x5179374
	public static Task<APIResult<WebviewGetPrivacyPolicyUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetPrivacyPolicyUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179420 Offset: 0x5175420 VA: 0x5179420
	public static APIResult<WebviewGetPaymentServiceActUrlV1.Types.Response> Send(WebviewGetPaymentServiceActUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51794BC Offset: 0x51754BC VA: 0x51794BC
	public static Task<APIResult<WebviewGetPaymentServiceActUrlV1.Types.Response>> SendAsync(WebviewGetPaymentServiceActUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51795B0 Offset: 0x51755B0 VA: 0x51795B0
	public static APIResult<WebviewGetPaymentServiceActUrlV1.Types.Response> SendWithAuthorize(WebviewGetPaymentServiceActUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517964C Offset: 0x517564C VA: 0x517964C
	public static Task<APIResult<WebviewGetPaymentServiceActUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetPaymentServiceActUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51796F8 Offset: 0x51756F8 VA: 0x51796F8
	public static APIResult<WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Response> Send(WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179794 Offset: 0x5175794 VA: 0x5179794
	public static Task<APIResult<WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Response>> SendAsync(WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179888 Offset: 0x5175888 VA: 0x5179888
	public static APIResult<WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Response> SendWithAuthorize(WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179924 Offset: 0x5175924 VA: 0x5179924
	public static Task<APIResult<WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetSpecifiedCommercialTransactionLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51799D0 Offset: 0x51759D0 VA: 0x51799D0
	public static APIResult<WebviewGetECommerceLawUrlV1.Types.Response> Send(WebviewGetECommerceLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179A6C Offset: 0x5175A6C VA: 0x5179A6C
	public static Task<APIResult<WebviewGetECommerceLawUrlV1.Types.Response>> SendAsync(WebviewGetECommerceLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179B60 Offset: 0x5175B60 VA: 0x5179B60
	public static APIResult<WebviewGetECommerceLawUrlV1.Types.Response> SendWithAuthorize(WebviewGetECommerceLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179BFC Offset: 0x5175BFC VA: 0x5179BFC
	public static Task<APIResult<WebviewGetECommerceLawUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetECommerceLawUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179CA8 Offset: 0x5175CA8 VA: 0x5179CA8
	public static APIResult<WebviewGetHowToUpdateUrlV1.Types.Response> Send(WebviewGetHowToUpdateUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179D44 Offset: 0x5175D44 VA: 0x5179D44
	public static Task<APIResult<WebviewGetHowToUpdateUrlV1.Types.Response>> SendAsync(WebviewGetHowToUpdateUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179E38 Offset: 0x5175E38 VA: 0x5179E38
	public static APIResult<WebviewGetHowToUpdateUrlV1.Types.Response> SendWithAuthorize(WebviewGetHowToUpdateUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5179ED4 Offset: 0x5175ED4 VA: 0x5179ED4
	public static Task<APIResult<WebviewGetHowToUpdateUrlV1.Types.Response>> SendWithAuthorizeAsync(WebviewGetHowToUpdateUrlV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class AssetService // TypeDefIndex: 2528
{
	// Methods

	// RVA: 0x517AD60 Offset: 0x5176D60 VA: 0x517AD60
	public static APIResult<AssetServiceGetSignedCookie.Types.Response> Send(AssetServiceGetSignedCookie.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517ADFC Offset: 0x5176DFC VA: 0x517ADFC
	public static Task<APIResult<AssetServiceGetSignedCookie.Types.Response>> SendAsync(AssetServiceGetSignedCookie.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517AEF0 Offset: 0x5176EF0 VA: 0x517AEF0
	public static APIResult<AssetServiceGetSignedCookie.Types.Response> SendWithAuthorize(AssetServiceGetSignedCookie.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517AF8C Offset: 0x5176F8C VA: 0x517AF8C
	public static Task<APIResult<AssetServiceGetSignedCookie.Types.Response>> SendWithAuthorizeAsync(AssetServiceGetSignedCookie.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B038 Offset: 0x5177038 VA: 0x517B038
	public static APIResult<AssetServiceGetVersions.Types.Response> Send(AssetServiceGetVersions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B0D4 Offset: 0x51770D4 VA: 0x517B0D4
	public static Task<APIResult<AssetServiceGetVersions.Types.Response>> SendAsync(AssetServiceGetVersions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B1C8 Offset: 0x51771C8 VA: 0x517B1C8
	public static APIResult<AssetServiceGetVersions.Types.Response> SendWithAuthorize(AssetServiceGetVersions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B264 Offset: 0x5177264 VA: 0x517B264
	public static Task<APIResult<AssetServiceGetVersions.Types.Response>> SendWithAuthorizeAsync(AssetServiceGetVersions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class CardExchange // TypeDefIndex: 2530
{
	// Methods

	// RVA: 0x517B5D0 Offset: 0x51775D0 VA: 0x517B5D0
	public static APIResult<CardExchangeSetRouteTypeV1.Types.Response> Send(CardExchangeSetRouteTypeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B66C Offset: 0x517766C VA: 0x517B66C
	public static Task<APIResult<CardExchangeSetRouteTypeV1.Types.Response>> SendAsync(CardExchangeSetRouteTypeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B760 Offset: 0x5177760 VA: 0x517B760
	public static APIResult<CardExchangeSetRouteTypeV1.Types.Response> SendWithAuthorize(CardExchangeSetRouteTypeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517B7FC Offset: 0x51777FC VA: 0x517B7FC
	public static Task<APIResult<CardExchangeSetRouteTypeV1.Types.Response>> SendWithAuthorizeAsync(CardExchangeSetRouteTypeV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class CardStock // TypeDefIndex: 2535
{
	// Methods

	// RVA: 0x517BA08 Offset: 0x5177A08 VA: 0x517BA08
	public static APIResult<CardStockGet.Types.Response> Send(CardStockGet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BAA4 Offset: 0x5177AA4 VA: 0x517BAA4
	public static Task<APIResult<CardStockGet.Types.Response>> SendAsync(CardStockGet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BB98 Offset: 0x5177B98 VA: 0x517BB98
	public static APIResult<CardStockGet.Types.Response> SendWithAuthorize(CardStockGet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BC34 Offset: 0x5177C34 VA: 0x517BC34
	public static Task<APIResult<CardStockGet.Types.Response>> SendWithAuthorizeAsync(CardStockGet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BCE0 Offset: 0x5177CE0 VA: 0x517BCE0
	public static APIResult<CardStockAdd.Types.Response> Send(CardStockAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BD7C Offset: 0x5177D7C VA: 0x517BD7C
	public static Task<APIResult<CardStockAdd.Types.Response>> SendAsync(CardStockAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BE70 Offset: 0x5177E70 VA: 0x517BE70
	public static APIResult<CardStockAdd.Types.Response> SendWithAuthorize(CardStockAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BF0C Offset: 0x5177F0C VA: 0x517BF0C
	public static Task<APIResult<CardStockAdd.Types.Response>> SendWithAuthorizeAsync(CardStockAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517BFB8 Offset: 0x5177FB8 VA: 0x517BFB8
	public static APIResult<CardStockPut.Types.Response> Send(CardStockPut.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C054 Offset: 0x5178054 VA: 0x517C054
	public static Task<APIResult<CardStockPut.Types.Response>> SendAsync(CardStockPut.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C148 Offset: 0x5178148 VA: 0x517C148
	public static APIResult<CardStockPut.Types.Response> SendWithAuthorize(CardStockPut.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C1E4 Offset: 0x51781E4 VA: 0x517C1E4
	public static Task<APIResult<CardStockPut.Types.Response>> SendWithAuthorizeAsync(CardStockPut.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C290 Offset: 0x5178290 VA: 0x517C290
	public static APIResult<CardStockDelete.Types.Response> Send(CardStockDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C32C Offset: 0x517832C VA: 0x517C32C
	public static Task<APIResult<CardStockDelete.Types.Response>> SendAsync(CardStockDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C420 Offset: 0x5178420 VA: 0x517C420
	public static APIResult<CardStockDelete.Types.Response> SendWithAuthorize(CardStockDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517C4BC Offset: 0x51784BC VA: 0x517C4BC
	public static Task<APIResult<CardStockDelete.Types.Response>> SendWithAuthorizeAsync(CardStockDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class DebugStorage // TypeDefIndex: 2538
{
	// Methods

	// RVA: 0x517CAF0 Offset: 0x5178AF0 VA: 0x517CAF0
	public static APIResult<DebugStorageSetEntriesV1.Types.Response> Send(DebugStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CB8C Offset: 0x5178B8C VA: 0x517CB8C
	public static Task<APIResult<DebugStorageSetEntriesV1.Types.Response>> SendAsync(DebugStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CC80 Offset: 0x5178C80 VA: 0x517CC80
	public static APIResult<DebugStorageSetEntriesV1.Types.Response> SendWithAuthorize(DebugStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CD1C Offset: 0x5178D1C VA: 0x517CD1C
	public static Task<APIResult<DebugStorageSetEntriesV1.Types.Response>> SendWithAuthorizeAsync(DebugStorageSetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CDC8 Offset: 0x5178DC8 VA: 0x517CDC8
	public static APIResult<DebugStorageGetEntriesV1.Types.Response> Send(DebugStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CE64 Offset: 0x5178E64 VA: 0x517CE64
	public static Task<APIResult<DebugStorageGetEntriesV1.Types.Response>> SendAsync(DebugStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CF58 Offset: 0x5178F58 VA: 0x517CF58
	public static APIResult<DebugStorageGetEntriesV1.Types.Response> SendWithAuthorize(DebugStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517CFF4 Offset: 0x5178FF4 VA: 0x517CFF4
	public static Task<APIResult<DebugStorageGetEntriesV1.Types.Response>> SendWithAuthorizeAsync(DebugStorageGetEntriesV1.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Feed // TypeDefIndex: 2544
{
	// Methods

	// RVA: 0x517D360 Offset: 0x5179360 VA: 0x517D360
	public static APIResult<FeedEnableTimelineRenewal.Types.Response> Send(FeedEnableTimelineRenewal.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D3FC Offset: 0x51793FC VA: 0x517D3FC
	public static Task<APIResult<FeedEnableTimelineRenewal.Types.Response>> SendAsync(FeedEnableTimelineRenewal.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D4F0 Offset: 0x51794F0 VA: 0x517D4F0
	public static APIResult<FeedEnableTimelineRenewal.Types.Response> SendWithAuthorize(FeedEnableTimelineRenewal.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D58C Offset: 0x517958C VA: 0x517D58C
	public static Task<APIResult<FeedEnableTimelineRenewal.Types.Response>> SendWithAuthorizeAsync(FeedEnableTimelineRenewal.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D638 Offset: 0x5179638 VA: 0x517D638
	public static APIResult<FeedAddPower.Types.Response> Send(FeedAddPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D6D4 Offset: 0x51796D4 VA: 0x517D6D4
	public static Task<APIResult<FeedAddPower.Types.Response>> SendAsync(FeedAddPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D7C8 Offset: 0x51797C8 VA: 0x517D7C8
	public static APIResult<FeedAddPower.Types.Response> SendWithAuthorize(FeedAddPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D864 Offset: 0x5179864 VA: 0x517D864
	public static Task<APIResult<FeedAddPower.Types.Response>> SendWithAuthorizeAsync(FeedAddPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D910 Offset: 0x5179910 VA: 0x517D910
	public static APIResult<FeedDeleteSharedPacks.Types.Response> Send(FeedDeleteSharedPacks.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517D9AC Offset: 0x51799AC VA: 0x517D9AC
	public static Task<APIResult<FeedDeleteSharedPacks.Types.Response>> SendAsync(FeedDeleteSharedPacks.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DAA0 Offset: 0x5179AA0 VA: 0x517DAA0
	public static APIResult<FeedDeleteSharedPacks.Types.Response> SendWithAuthorize(FeedDeleteSharedPacks.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DB3C Offset: 0x5179B3C VA: 0x517DB3C
	public static Task<APIResult<FeedDeleteSharedPacks.Types.Response>> SendWithAuthorizeAsync(FeedDeleteSharedPacks.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DBE8 Offset: 0x5179BE8 VA: 0x517DBE8
	public static APIResult<FeedRenewTimelineWithOptions.Types.Response> Send(FeedRenewTimelineWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DC84 Offset: 0x5179C84 VA: 0x517DC84
	public static Task<APIResult<FeedRenewTimelineWithOptions.Types.Response>> SendAsync(FeedRenewTimelineWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DD78 Offset: 0x5179D78 VA: 0x517DD78
	public static APIResult<FeedRenewTimelineWithOptions.Types.Response> SendWithAuthorize(FeedRenewTimelineWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DE14 Offset: 0x5179E14 VA: 0x517DE14
	public static Task<APIResult<FeedRenewTimelineWithOptions.Types.Response>> SendWithAuthorizeAsync(FeedRenewTimelineWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DEC0 Offset: 0x5179EC0 VA: 0x517DEC0
	public static APIResult<FeedChallengeWithOptions.Types.Response> Send(FeedChallengeWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517DF5C Offset: 0x5179F5C VA: 0x517DF5C
	public static Task<APIResult<FeedChallengeWithOptions.Types.Response>> SendAsync(FeedChallengeWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517E050 Offset: 0x517A050 VA: 0x517E050
	public static APIResult<FeedChallengeWithOptions.Types.Response> SendWithAuthorize(FeedChallengeWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517E0EC Offset: 0x517A0EC VA: 0x517E0EC
	public static Task<APIResult<FeedChallengeWithOptions.Types.Response>> SendWithAuthorizeAsync(FeedChallengeWithOptions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Friend // TypeDefIndex: 2551
{
	// Methods

	// RVA: 0x517E884 Offset: 0x517A884 VA: 0x517E884
	public static APIResult<FriendAdd.Types.Response> Send(FriendAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517E920 Offset: 0x517A920 VA: 0x517E920
	public static Task<APIResult<FriendAdd.Types.Response>> SendAsync(FriendAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EA14 Offset: 0x517AA14 VA: 0x517EA14
	public static APIResult<FriendAdd.Types.Response> SendWithAuthorize(FriendAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EAB0 Offset: 0x517AAB0 VA: 0x517EAB0
	public static Task<APIResult<FriendAdd.Types.Response>> SendWithAuthorizeAsync(FriendAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EB5C Offset: 0x517AB5C VA: 0x517EB5C
	public static APIResult<FriendAddExisting.Types.Response> Send(FriendAddExisting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EBF8 Offset: 0x517ABF8 VA: 0x517EBF8
	public static Task<APIResult<FriendAddExisting.Types.Response>> SendAsync(FriendAddExisting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517ECEC Offset: 0x517ACEC VA: 0x517ECEC
	public static APIResult<FriendAddExisting.Types.Response> SendWithAuthorize(FriendAddExisting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517ED88 Offset: 0x517AD88 VA: 0x517ED88
	public static Task<APIResult<FriendAddExisting.Types.Response>> SendWithAuthorizeAsync(FriendAddExisting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EE34 Offset: 0x517AE34 VA: 0x517EE34
	public static APIResult<FriendSendRequests.Types.Response> Send(FriendSendRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EED0 Offset: 0x517AED0 VA: 0x517EED0
	public static Task<APIResult<FriendSendRequests.Types.Response>> SendAsync(FriendSendRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517EFC4 Offset: 0x517AFC4 VA: 0x517EFC4
	public static APIResult<FriendSendRequests.Types.Response> SendWithAuthorize(FriendSendRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F060 Offset: 0x517B060 VA: 0x517F060
	public static Task<APIResult<FriendSendRequests.Types.Response>> SendWithAuthorizeAsync(FriendSendRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F10C Offset: 0x517B10C VA: 0x517F10C
	public static APIResult<FriendApproveRequests.Types.Response> Send(FriendApproveRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F1A8 Offset: 0x517B1A8 VA: 0x517F1A8
	public static Task<APIResult<FriendApproveRequests.Types.Response>> SendAsync(FriendApproveRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F29C Offset: 0x517B29C VA: 0x517F29C
	public static APIResult<FriendApproveRequests.Types.Response> SendWithAuthorize(FriendApproveRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F338 Offset: 0x517B338 VA: 0x517F338
	public static Task<APIResult<FriendApproveRequests.Types.Response>> SendWithAuthorizeAsync(FriendApproveRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F3E4 Offset: 0x517B3E4 VA: 0x517F3E4
	public static APIResult<FriendCancelRequests.Types.Response> Send(FriendCancelRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F480 Offset: 0x517B480 VA: 0x517F480
	public static Task<APIResult<FriendCancelRequests.Types.Response>> SendAsync(FriendCancelRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F574 Offset: 0x517B574 VA: 0x517F574
	public static APIResult<FriendCancelRequests.Types.Response> SendWithAuthorize(FriendCancelRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F610 Offset: 0x517B610 VA: 0x517F610
	public static Task<APIResult<FriendCancelRequests.Types.Response>> SendWithAuthorizeAsync(FriendCancelRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F6BC Offset: 0x517B6BC VA: 0x517F6BC
	public static APIResult<FriendRejectRequests.Types.Response> Send(FriendRejectRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F758 Offset: 0x517B758 VA: 0x517F758
	public static Task<APIResult<FriendRejectRequests.Types.Response>> SendAsync(FriendRejectRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F84C Offset: 0x517B84C VA: 0x517F84C
	public static APIResult<FriendRejectRequests.Types.Response> SendWithAuthorize(FriendRejectRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x517F8E8 Offset: 0x517B8E8 VA: 0x517F8E8
	public static Task<APIResult<FriendRejectRequests.Types.Response>> SendWithAuthorizeAsync(FriendRejectRequests.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class GMToolLog // TypeDefIndex: 2553
{
	// Methods

	// RVA: 0x51801E4 Offset: 0x517C1E4 VA: 0x51801E4
	public static APIResult<GMToolLogEmit.Types.Response> Send(GMToolLogEmit.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180280 Offset: 0x517C280 VA: 0x5180280
	public static Task<APIResult<GMToolLogEmit.Types.Response>> SendAsync(GMToolLogEmit.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180374 Offset: 0x517C374 VA: 0x5180374
	public static APIResult<GMToolLogEmit.Types.Response> SendWithAuthorize(GMToolLogEmit.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180410 Offset: 0x517C410 VA: 0x5180410
	public static Task<APIResult<GMToolLogEmit.Types.Response>> SendWithAuthorizeAsync(GMToolLogEmit.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Item // TypeDefIndex: 2556
{
	// Methods

	// RVA: 0x518061C Offset: 0x517C61C VA: 0x518061C
	public static APIResult<ItemAdd.Types.Response> Send(ItemAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51806B8 Offset: 0x517C6B8 VA: 0x51806B8
	public static Task<APIResult<ItemAdd.Types.Response>> SendAsync(ItemAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51807AC Offset: 0x517C7AC VA: 0x51807AC
	public static APIResult<ItemAdd.Types.Response> SendWithAuthorize(ItemAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180848 Offset: 0x517C848 VA: 0x5180848
	public static Task<APIResult<ItemAdd.Types.Response>> SendWithAuthorizeAsync(ItemAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51808F4 Offset: 0x517C8F4 VA: 0x51808F4
	public static APIResult<ItemAddToPlayers.Types.Response> Send(ItemAddToPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180990 Offset: 0x517C990 VA: 0x5180990
	public static Task<APIResult<ItemAddToPlayers.Types.Response>> SendAsync(ItemAddToPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180A84 Offset: 0x517CA84 VA: 0x5180A84
	public static APIResult<ItemAddToPlayers.Types.Response> SendWithAuthorize(ItemAddToPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180B20 Offset: 0x517CB20 VA: 0x5180B20
	public static Task<APIResult<ItemAddToPlayers.Types.Response>> SendWithAuthorizeAsync(ItemAddToPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class ItemShop // TypeDefIndex: 2559
{
	// Methods

	// RVA: 0x5180E8C Offset: 0x517CE8C VA: 0x5180E8C
	public static APIResult<ItemShopAddPurchaseSummaries.Types.Response> Send(ItemShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5180F28 Offset: 0x517CF28 VA: 0x5180F28
	public static Task<APIResult<ItemShopAddPurchaseSummaries.Types.Response>> SendAsync(ItemShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518101C Offset: 0x517D01C VA: 0x518101C
	public static APIResult<ItemShopAddPurchaseSummaries.Types.Response> SendWithAuthorize(ItemShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51810B8 Offset: 0x517D0B8 VA: 0x51810B8
	public static Task<APIResult<ItemShopAddPurchaseSummaries.Types.Response>> SendWithAuthorizeAsync(ItemShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181164 Offset: 0x517D164 VA: 0x5181164
	public static APIResult<ItemShopDeletePurchaseSummaries.Types.Response> Send(ItemShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181200 Offset: 0x517D200 VA: 0x5181200
	public static Task<APIResult<ItemShopDeletePurchaseSummaries.Types.Response>> SendAsync(ItemShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51812F4 Offset: 0x517D2F4 VA: 0x51812F4
	public static APIResult<ItemShopDeletePurchaseSummaries.Types.Response> SendWithAuthorize(ItemShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181390 Offset: 0x517D390 VA: 0x5181390
	public static Task<APIResult<ItemShopDeletePurchaseSummaries.Types.Response>> SendWithAuthorizeAsync(ItemShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Mission // TypeDefIndex: 2563
{
	// Methods

	// RVA: 0x51816FC Offset: 0x517D6FC VA: 0x51816FC
	public static APIResult<MissionAddAction.Types.Response> Send(MissionAddAction.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181798 Offset: 0x517D798 VA: 0x5181798
	public static Task<APIResult<MissionAddAction.Types.Response>> SendAsync(MissionAddAction.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518188C Offset: 0x517D88C VA: 0x518188C
	public static APIResult<MissionAddAction.Types.Response> SendWithAuthorize(MissionAddAction.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181928 Offset: 0x517D928 VA: 0x5181928
	public static Task<APIResult<MissionAddAction.Types.Response>> SendWithAuthorizeAsync(MissionAddAction.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51819D4 Offset: 0x517D9D4 VA: 0x51819D4
	public static APIResult<MissionUndoClear.Types.Response> Send(MissionUndoClear.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181A70 Offset: 0x517DA70 VA: 0x5181A70
	public static Task<APIResult<MissionUndoClear.Types.Response>> SendAsync(MissionUndoClear.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181B64 Offset: 0x517DB64 VA: 0x5181B64
	public static APIResult<MissionUndoClear.Types.Response> SendWithAuthorize(MissionUndoClear.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181C00 Offset: 0x517DC00 VA: 0x5181C00
	public static Task<APIResult<MissionUndoClear.Types.Response>> SendWithAuthorizeAsync(MissionUndoClear.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181CAC Offset: 0x517DCAC VA: 0x5181CAC
	public static APIResult<MissionAddBulkActions.Types.Response> Send(MissionAddBulkActions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181D48 Offset: 0x517DD48 VA: 0x5181D48
	public static Task<APIResult<MissionAddBulkActions.Types.Response>> SendAsync(MissionAddBulkActions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181E3C Offset: 0x517DE3C VA: 0x5181E3C
	public static APIResult<MissionAddBulkActions.Types.Response> SendWithAuthorize(MissionAddBulkActions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5181ED8 Offset: 0x517DED8 VA: 0x5181ED8
	public static Task<APIResult<MissionAddBulkActions.Types.Response>> SendWithAuthorizeAsync(MissionAddBulkActions.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class MyCollection // TypeDefIndex: 2566
{
	// Methods

	// RVA: 0x51823A8 Offset: 0x517E3A8 VA: 0x51823A8
	public static APIResult<MyCollectionAddCollection.Types.Response> Send(MyCollectionAddCollection.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182444 Offset: 0x517E444 VA: 0x5182444
	public static Task<APIResult<MyCollectionAddCollection.Types.Response>> SendAsync(MyCollectionAddCollection.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182538 Offset: 0x517E538 VA: 0x5182538
	public static APIResult<MyCollectionAddCollection.Types.Response> SendWithAuthorize(MyCollectionAddCollection.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51825D4 Offset: 0x517E5D4 VA: 0x51825D4
	public static Task<APIResult<MyCollectionAddCollection.Types.Response>> SendWithAuthorizeAsync(MyCollectionAddCollection.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182680 Offset: 0x517E680 VA: 0x5182680
	public static APIResult<MyCollectionSetLikeCount.Types.Response> Send(MyCollectionSetLikeCount.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518271C Offset: 0x517E71C VA: 0x518271C
	public static Task<APIResult<MyCollectionSetLikeCount.Types.Response>> SendAsync(MyCollectionSetLikeCount.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182810 Offset: 0x517E810 VA: 0x5182810
	public static APIResult<MyCollectionSetLikeCount.Types.Response> SendWithAuthorize(MyCollectionSetLikeCount.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51828AC Offset: 0x517E8AC VA: 0x51828AC
	public static Task<APIResult<MyCollectionSetLikeCount.Types.Response>> SendWithAuthorizeAsync(MyCollectionSetLikeCount.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class PackPower // TypeDefIndex: 2568
{
	// Methods

	// RVA: 0x5182C18 Offset: 0x517EC18 VA: 0x5182C18
	public static APIResult<PackPowerAdd.Types.Response> Send(PackPowerAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182CB4 Offset: 0x517ECB4 VA: 0x5182CB4
	public static Task<APIResult<PackPowerAdd.Types.Response>> SendAsync(PackPowerAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182DA8 Offset: 0x517EDA8 VA: 0x5182DA8
	public static APIResult<PackPowerAdd.Types.Response> SendWithAuthorize(PackPowerAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5182E44 Offset: 0x517EE44 VA: 0x5182E44
	public static Task<APIResult<PackPowerAdd.Types.Response>> SendWithAuthorizeAsync(PackPowerAdd.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Pass // TypeDefIndex: 2573
{
	// Methods

	// RVA: 0x5183050 Offset: 0x517F050 VA: 0x5183050
	public static APIResult<PassPurchaseMock.Types.Response> Send(PassPurchaseMock.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51830EC Offset: 0x517F0EC VA: 0x51830EC
	public static Task<APIResult<PassPurchaseMock.Types.Response>> SendAsync(PassPurchaseMock.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51831E0 Offset: 0x517F1E0 VA: 0x51831E0
	public static APIResult<PassPurchaseMock.Types.Response> SendWithAuthorize(PassPurchaseMock.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518327C Offset: 0x517F27C VA: 0x518327C
	public static Task<APIResult<PassPurchaseMock.Types.Response>> SendWithAuthorizeAsync(PassPurchaseMock.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183328 Offset: 0x517F328 VA: 0x5183328
	public static APIResult<PassUnlinkMarket.Types.Response> Send(PassUnlinkMarket.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51833C4 Offset: 0x517F3C4 VA: 0x51833C4
	public static Task<APIResult<PassUnlinkMarket.Types.Response>> SendAsync(PassUnlinkMarket.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51834B8 Offset: 0x517F4B8 VA: 0x51834B8
	public static APIResult<PassUnlinkMarket.Types.Response> SendWithAuthorize(PassUnlinkMarket.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183554 Offset: 0x517F554 VA: 0x5183554
	public static Task<APIResult<PassUnlinkMarket.Types.Response>> SendWithAuthorizeAsync(PassUnlinkMarket.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183600 Offset: 0x517F600 VA: 0x5183600
	public static APIResult<PassDetectFreeTrialViolation.Types.Response> Send(PassDetectFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518369C Offset: 0x517F69C VA: 0x518369C
	public static Task<APIResult<PassDetectFreeTrialViolation.Types.Response>> SendAsync(PassDetectFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183790 Offset: 0x517F790 VA: 0x5183790
	public static APIResult<PassDetectFreeTrialViolation.Types.Response> SendWithAuthorize(PassDetectFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518382C Offset: 0x517F82C VA: 0x518382C
	public static Task<APIResult<PassDetectFreeTrialViolation.Types.Response>> SendWithAuthorizeAsync(PassDetectFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51838D8 Offset: 0x517F8D8 VA: 0x51838D8
	public static APIResult<PassResetFreeTrialViolation.Types.Response> Send(PassResetFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183974 Offset: 0x517F974 VA: 0x5183974
	public static Task<APIResult<PassResetFreeTrialViolation.Types.Response>> SendAsync(PassResetFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183A68 Offset: 0x517FA68 VA: 0x5183A68
	public static APIResult<PassResetFreeTrialViolation.Types.Response> SendWithAuthorize(PassResetFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5183B04 Offset: 0x517FB04 VA: 0x5183B04
	public static Task<APIResult<PassResetFreeTrialViolation.Types.Response>> SendWithAuthorizeAsync(PassResetFreeTrialViolation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Player // TypeDefIndex: 2584
{
	// Methods

	// RVA: 0x5184138 Offset: 0x5180138 VA: 0x5184138
	public static APIResult<PlayerCreate.Types.Response> Send(PlayerCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51841D4 Offset: 0x51801D4 VA: 0x51841D4
	public static Task<APIResult<PlayerCreate.Types.Response>> SendAsync(PlayerCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51842C8 Offset: 0x51802C8 VA: 0x51842C8
	public static APIResult<PlayerCreate.Types.Response> SendWithAuthorize(PlayerCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184364 Offset: 0x5180364 VA: 0x5184364
	public static Task<APIResult<PlayerCreate.Types.Response>> SendWithAuthorizeAsync(PlayerCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184410 Offset: 0x5180410 VA: 0x5184410
	public static APIResult<PlayerDelete.Types.Response> Send(PlayerDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51844AC Offset: 0x51804AC VA: 0x51844AC
	public static Task<APIResult<PlayerDelete.Types.Response>> SendAsync(PlayerDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51845A0 Offset: 0x51805A0 VA: 0x51845A0
	public static APIResult<PlayerDelete.Types.Response> SendWithAuthorize(PlayerDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518463C Offset: 0x518063C VA: 0x518463C
	public static Task<APIResult<PlayerDelete.Types.Response>> SendWithAuthorizeAsync(PlayerDelete.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51846E8 Offset: 0x51806E8 VA: 0x51846E8
	public static APIResult<PlayerSetLastLoggedIn.Types.Response> Send(PlayerSetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184784 Offset: 0x5180784 VA: 0x5184784
	public static Task<APIResult<PlayerSetLastLoggedIn.Types.Response>> SendAsync(PlayerSetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184878 Offset: 0x5180878 VA: 0x5184878
	public static APIResult<PlayerSetLastLoggedIn.Types.Response> SendWithAuthorize(PlayerSetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184914 Offset: 0x5180914 VA: 0x5184914
	public static Task<APIResult<PlayerSetLastLoggedIn.Types.Response>> SendWithAuthorizeAsync(PlayerSetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51849C0 Offset: 0x51809C0 VA: 0x51849C0
	public static APIResult<PlayerGetLastLoggedIn.Types.Response> Send(PlayerGetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184A5C Offset: 0x5180A5C VA: 0x5184A5C
	public static Task<APIResult<PlayerGetLastLoggedIn.Types.Response>> SendAsync(PlayerGetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184B50 Offset: 0x5180B50 VA: 0x5184B50
	public static APIResult<PlayerGetLastLoggedIn.Types.Response> SendWithAuthorize(PlayerGetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184BEC Offset: 0x5180BEC VA: 0x5184BEC
	public static Task<APIResult<PlayerGetLastLoggedIn.Types.Response>> SendWithAuthorizeAsync(PlayerGetLastLoggedIn.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184C98 Offset: 0x5180C98 VA: 0x5184C98
	public static APIResult<PlayerSetAvailable.Types.Response> Send(PlayerSetAvailable.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184D34 Offset: 0x5180D34 VA: 0x5184D34
	public static Task<APIResult<PlayerSetAvailable.Types.Response>> SendAsync(PlayerSetAvailable.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184E28 Offset: 0x5180E28 VA: 0x5184E28
	public static APIResult<PlayerSetAvailable.Types.Response> SendWithAuthorize(PlayerSetAvailable.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184EC4 Offset: 0x5180EC4 VA: 0x5184EC4
	public static Task<APIResult<PlayerSetAvailable.Types.Response>> SendWithAuthorizeAsync(PlayerSetAvailable.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5184F70 Offset: 0x5180F70 VA: 0x5184F70
	public static APIResult<PlayerSetBaasUserDebugSetting.Types.Response> Send(PlayerSetBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518500C Offset: 0x518100C VA: 0x518500C
	public static Task<APIResult<PlayerSetBaasUserDebugSetting.Types.Response>> SendAsync(PlayerSetBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185100 Offset: 0x5181100 VA: 0x5185100
	public static APIResult<PlayerSetBaasUserDebugSetting.Types.Response> SendWithAuthorize(PlayerSetBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518519C Offset: 0x518119C VA: 0x518519C
	public static Task<APIResult<PlayerSetBaasUserDebugSetting.Types.Response>> SendWithAuthorizeAsync(PlayerSetBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185248 Offset: 0x5181248 VA: 0x5185248
	public static APIResult<PlayerDeleteBaasUserDebugSetting.Types.Response> Send(PlayerDeleteBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51852E4 Offset: 0x51812E4 VA: 0x51852E4
	public static Task<APIResult<PlayerDeleteBaasUserDebugSetting.Types.Response>> SendAsync(PlayerDeleteBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51853D8 Offset: 0x51813D8 VA: 0x51853D8
	public static APIResult<PlayerDeleteBaasUserDebugSetting.Types.Response> SendWithAuthorize(PlayerDeleteBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185474 Offset: 0x5181474 VA: 0x5185474
	public static Task<APIResult<PlayerDeleteBaasUserDebugSetting.Types.Response>> SendWithAuthorizeAsync(PlayerDeleteBaasUserDebugSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185520 Offset: 0x5181520 VA: 0x5185520
	public static APIResult<PlayerSetPlayerSetting.Types.Response> Send(PlayerSetPlayerSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51855BC Offset: 0x51815BC VA: 0x51855BC
	public static Task<APIResult<PlayerSetPlayerSetting.Types.Response>> SendAsync(PlayerSetPlayerSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51856B0 Offset: 0x51816B0 VA: 0x51856B0
	public static APIResult<PlayerSetPlayerSetting.Types.Response> SendWithAuthorize(PlayerSetPlayerSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518574C Offset: 0x518174C VA: 0x518574C
	public static Task<APIResult<PlayerSetPlayerSetting.Types.Response>> SendWithAuthorizeAsync(PlayerSetPlayerSetting.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51857F8 Offset: 0x51817F8 VA: 0x51857F8
	public static APIResult<PlayerAdjustmentTimestamp.Types.Response> Send(PlayerAdjustmentTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185894 Offset: 0x5181894 VA: 0x5185894
	public static Task<APIResult<PlayerAdjustmentTimestamp.Types.Response>> SendAsync(PlayerAdjustmentTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185988 Offset: 0x5181988 VA: 0x5185988
	public static APIResult<PlayerAdjustmentTimestamp.Types.Response> SendWithAuthorize(PlayerAdjustmentTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185A24 Offset: 0x5181A24 VA: 0x5185A24
	public static Task<APIResult<PlayerAdjustmentTimestamp.Types.Response>> SendWithAuthorizeAsync(PlayerAdjustmentTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185AD0 Offset: 0x5181AD0 VA: 0x5185AD0
	public static APIResult<PlayerAdjustmentRelativeTimestamp.Types.Response> Send(PlayerAdjustmentRelativeTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185B6C Offset: 0x5181B6C VA: 0x5185B6C
	public static Task<APIResult<PlayerAdjustmentRelativeTimestamp.Types.Response>> SendAsync(PlayerAdjustmentRelativeTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185C60 Offset: 0x5181C60 VA: 0x5185C60
	public static APIResult<PlayerAdjustmentRelativeTimestamp.Types.Response> SendWithAuthorize(PlayerAdjustmentRelativeTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5185CFC Offset: 0x5181CFC VA: 0x5185CFC
	public static Task<APIResult<PlayerAdjustmentRelativeTimestamp.Types.Response>> SendWithAuthorizeAsync(PlayerAdjustmentRelativeTimestamp.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class PokeGoldShop // TypeDefIndex: 2587
{
	// Methods

	// RVA: 0x5186B88 Offset: 0x5182B88 VA: 0x5186B88
	public static APIResult<PokeGoldShopAddPurchaseSummaries.Types.Response> Send(PokeGoldShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186C24 Offset: 0x5182C24 VA: 0x5186C24
	public static Task<APIResult<PokeGoldShopAddPurchaseSummaries.Types.Response>> SendAsync(PokeGoldShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186D18 Offset: 0x5182D18 VA: 0x5186D18
	public static APIResult<PokeGoldShopAddPurchaseSummaries.Types.Response> SendWithAuthorize(PokeGoldShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186DB4 Offset: 0x5182DB4 VA: 0x5186DB4
	public static Task<APIResult<PokeGoldShopAddPurchaseSummaries.Types.Response>> SendWithAuthorizeAsync(PokeGoldShopAddPurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186E60 Offset: 0x5182E60 VA: 0x5186E60
	public static APIResult<PokeGoldShopDeletePurchaseSummaries.Types.Response> Send(PokeGoldShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186EFC Offset: 0x5182EFC VA: 0x5186EFC
	public static Task<APIResult<PokeGoldShopDeletePurchaseSummaries.Types.Response>> SendAsync(PokeGoldShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5186FF0 Offset: 0x5182FF0 VA: 0x5186FF0
	public static APIResult<PokeGoldShopDeletePurchaseSummaries.Types.Response> SendWithAuthorize(PokeGoldShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518708C Offset: 0x518308C VA: 0x518708C
	public static Task<APIResult<PokeGoldShopDeletePurchaseSummaries.Types.Response>> SendWithAuthorizeAsync(PokeGoldShopDeletePurchaseSummaries.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Present // TypeDefIndex: 2589
{
	// Methods

	// RVA: 0x51873F8 Offset: 0x51833F8 VA: 0x51873F8
	public static APIResult<PresentCreate.Types.Response> Send(PresentCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187494 Offset: 0x5183494 VA: 0x5187494
	public static Task<APIResult<PresentCreate.Types.Response>> SendAsync(PresentCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187588 Offset: 0x5183588 VA: 0x5187588
	public static APIResult<PresentCreate.Types.Response> SendWithAuthorize(PresentCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187624 Offset: 0x5183624 VA: 0x5187624
	public static Task<APIResult<PresentCreate.Types.Response>> SendWithAuthorizeAsync(PresentCreate.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Profile // TypeDefIndex: 2592
{
	// Methods

	// RVA: 0x5187830 Offset: 0x5183830 VA: 0x5187830
	public static APIResult<ProfileSetProfiles.Types.Response> Send(ProfileSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51878CC Offset: 0x51838CC VA: 0x51878CC
	public static Task<APIResult<ProfileSetProfiles.Types.Response>> SendAsync(ProfileSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51879C0 Offset: 0x51839C0 VA: 0x51879C0
	public static APIResult<ProfileSetProfiles.Types.Response> SendWithAuthorize(ProfileSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187A5C Offset: 0x5183A5C VA: 0x5187A5C
	public static Task<APIResult<ProfileSetProfiles.Types.Response>> SendWithAuthorizeAsync(ProfileSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187B08 Offset: 0x5183B08 VA: 0x5187B08
	public static APIResult<ProfileResetNicknameChangedAt.Types.Response> Send(ProfileResetNicknameChangedAt.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187BA4 Offset: 0x5183BA4 VA: 0x5187BA4
	public static Task<APIResult<ProfileResetNicknameChangedAt.Types.Response>> SendAsync(ProfileResetNicknameChangedAt.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187C98 Offset: 0x5183C98 VA: 0x5187C98
	public static APIResult<ProfileResetNicknameChangedAt.Types.Response> SendWithAuthorize(ProfileResetNicknameChangedAt.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5187D34 Offset: 0x5183D34 VA: 0x5187D34
	public static Task<APIResult<ProfileResetNicknameChangedAt.Types.Response>> SendWithAuthorizeAsync(ProfileResetNicknameChangedAt.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class PvpCasual // TypeDefIndex: 2596
{
	// Methods

	// RVA: 0x51880A0 Offset: 0x51840A0 VA: 0x51880A0
	public static APIResult<PvpCasualSetProfiles.Types.Response> Send(PvpCasualSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518813C Offset: 0x518413C VA: 0x518813C
	public static Task<APIResult<PvpCasualSetProfiles.Types.Response>> SendAsync(PvpCasualSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188230 Offset: 0x5184230 VA: 0x5188230
	public static APIResult<PvpCasualSetProfiles.Types.Response> SendWithAuthorize(PvpCasualSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51882CC Offset: 0x51842CC VA: 0x51882CC
	public static Task<APIResult<PvpCasualSetProfiles.Types.Response>> SendWithAuthorizeAsync(PvpCasualSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188378 Offset: 0x5184378 VA: 0x5188378
	public static APIResult<PvpCasualSetProfileUpdateMode.Types.Response> Send(PvpCasualSetProfileUpdateMode.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188414 Offset: 0x5184414 VA: 0x5188414
	public static Task<APIResult<PvpCasualSetProfileUpdateMode.Types.Response>> SendAsync(PvpCasualSetProfileUpdateMode.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188508 Offset: 0x5184508 VA: 0x5188508
	public static APIResult<PvpCasualSetProfileUpdateMode.Types.Response> SendWithAuthorize(PvpCasualSetProfileUpdateMode.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51885A4 Offset: 0x51845A4 VA: 0x51885A4
	public static Task<APIResult<PvpCasualSetProfileUpdateMode.Types.Response>> SendWithAuthorizeAsync(PvpCasualSetProfileUpdateMode.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188650 Offset: 0x5184650 VA: 0x5188650
	public static APIResult<PvpCasualGetProfile.Types.Response> Send(PvpCasualGetProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51886EC Offset: 0x51846EC VA: 0x51886EC
	public static Task<APIResult<PvpCasualGetProfile.Types.Response>> SendAsync(PvpCasualGetProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51887E0 Offset: 0x51847E0 VA: 0x51887E0
	public static APIResult<PvpCasualGetProfile.Types.Response> SendWithAuthorize(PvpCasualGetProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518887C Offset: 0x518487C VA: 0x518887C
	public static Task<APIResult<PvpCasualGetProfile.Types.Response>> SendWithAuthorizeAsync(PvpCasualGetProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class PvpEvent // TypeDefIndex: 2598
{
	// Methods

	// RVA: 0x5188D4C Offset: 0x5184D4C VA: 0x5188D4C
	public static APIResult<PvpEventSetProfiles.Types.Response> Send(PvpEventSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188DE8 Offset: 0x5184DE8 VA: 0x5188DE8
	public static Task<APIResult<PvpEventSetProfiles.Types.Response>> SendAsync(PvpEventSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188EDC Offset: 0x5184EDC VA: 0x5188EDC
	public static APIResult<PvpEventSetProfiles.Types.Response> SendWithAuthorize(PvpEventSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5188F78 Offset: 0x5184F78 VA: 0x5188F78
	public static Task<APIResult<PvpEventSetProfiles.Types.Response>> SendWithAuthorizeAsync(PvpEventSetProfiles.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class PvpRank // TypeDefIndex: 2610
{
	// Methods

	// RVA: 0x5189184 Offset: 0x5185184 VA: 0x5189184
	public static APIResult<PvpRankSetRankingPlayerPoints.Types.Response> Send(PvpRankSetRankingPlayerPoints.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189220 Offset: 0x5185220 VA: 0x5189220
	public static Task<APIResult<PvpRankSetRankingPlayerPoints.Types.Response>> SendAsync(PvpRankSetRankingPlayerPoints.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189314 Offset: 0x5185314 VA: 0x5189314
	public static APIResult<PvpRankSetRankingPlayerPoints.Types.Response> SendWithAuthorize(PvpRankSetRankingPlayerPoints.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51893B0 Offset: 0x51853B0 VA: 0x51893B0
	public static Task<APIResult<PvpRankSetRankingPlayerPoints.Types.Response>> SendWithAuthorizeAsync(PvpRankSetRankingPlayerPoints.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518945C Offset: 0x518545C VA: 0x518945C
	public static APIResult<PvpRankResetRanking.Types.Response> Send(PvpRankResetRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51894F8 Offset: 0x51854F8 VA: 0x51894F8
	public static Task<APIResult<PvpRankResetRanking.Types.Response>> SendAsync(PvpRankResetRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51895EC Offset: 0x51855EC VA: 0x51895EC
	public static APIResult<PvpRankResetRanking.Types.Response> SendWithAuthorize(PvpRankResetRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189688 Offset: 0x5185688 VA: 0x5189688
	public static Task<APIResult<PvpRankResetRanking.Types.Response>> SendWithAuthorizeAsync(PvpRankResetRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189734 Offset: 0x5185734 VA: 0x5189734
	public static APIResult<PvpRankAggregateRanking.Types.Response> Send(PvpRankAggregateRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51897D0 Offset: 0x51857D0 VA: 0x51897D0
	public static Task<APIResult<PvpRankAggregateRanking.Types.Response>> SendAsync(PvpRankAggregateRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x51898C4 Offset: 0x51858C4 VA: 0x51898C4
	public static APIResult<PvpRankAggregateRanking.Types.Response> SendWithAuthorize(PvpRankAggregateRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189960 Offset: 0x5185960 VA: 0x5189960
	public static Task<APIResult<PvpRankAggregateRanking.Types.Response>> SendWithAuthorizeAsync(PvpRankAggregateRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189A0C Offset: 0x5185A0C VA: 0x5189A0C
	public static APIResult<PvpRankConfirmRanking.Types.Response> Send(PvpRankConfirmRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189AA8 Offset: 0x5185AA8 VA: 0x5189AA8
	public static Task<APIResult<PvpRankConfirmRanking.Types.Response>> SendAsync(PvpRankConfirmRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189B9C Offset: 0x5185B9C VA: 0x5189B9C
	public static APIResult<PvpRankConfirmRanking.Types.Response> SendWithAuthorize(PvpRankConfirmRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189C38 Offset: 0x5185C38 VA: 0x5189C38
	public static Task<APIResult<PvpRankConfirmRanking.Types.Response>> SendWithAuthorizeAsync(PvpRankConfirmRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189CE4 Offset: 0x5185CE4 VA: 0x5189CE4
	public static APIResult<PvpRankResetRankingAggregation.Types.Response> Send(PvpRankResetRankingAggregation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189D80 Offset: 0x5185D80 VA: 0x5189D80
	public static Task<APIResult<PvpRankResetRankingAggregation.Types.Response>> SendAsync(PvpRankResetRankingAggregation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189E74 Offset: 0x5185E74 VA: 0x5189E74
	public static APIResult<PvpRankResetRankingAggregation.Types.Response> SendWithAuthorize(PvpRankResetRankingAggregation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189F10 Offset: 0x5185F10 VA: 0x5189F10
	public static Task<APIResult<PvpRankResetRankingAggregation.Types.Response>> SendWithAuthorizeAsync(PvpRankResetRankingAggregation.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x5189FBC Offset: 0x5185FBC VA: 0x5189FBC
	public static APIResult<PvpRankRestoreRanking.Types.Response> Send(PvpRankRestoreRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A058 Offset: 0x5186058 VA: 0x518A058
	public static Task<APIResult<PvpRankRestoreRanking.Types.Response>> SendAsync(PvpRankRestoreRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A14C Offset: 0x518614C VA: 0x518A14C
	public static APIResult<PvpRankRestoreRanking.Types.Response> SendWithAuthorize(PvpRankRestoreRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A1E8 Offset: 0x51861E8 VA: 0x518A1E8
	public static Task<APIResult<PvpRankRestoreRanking.Types.Response>> SendWithAuthorizeAsync(PvpRankRestoreRanking.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A294 Offset: 0x5186294 VA: 0x518A294
	public static APIResult<PvpRankAddRankingDummyPlayers.Types.Response> Send(PvpRankAddRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A330 Offset: 0x5186330 VA: 0x518A330
	public static Task<APIResult<PvpRankAddRankingDummyPlayers.Types.Response>> SendAsync(PvpRankAddRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A424 Offset: 0x5186424 VA: 0x518A424
	public static APIResult<PvpRankAddRankingDummyPlayers.Types.Response> SendWithAuthorize(PvpRankAddRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A4C0 Offset: 0x51864C0 VA: 0x518A4C0
	public static Task<APIResult<PvpRankAddRankingDummyPlayers.Types.Response>> SendWithAuthorizeAsync(PvpRankAddRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A56C Offset: 0x518656C VA: 0x518A56C
	public static APIResult<PvpRankAddPastRankingDummyPlayers.Types.Response> Send(PvpRankAddPastRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A608 Offset: 0x5186608 VA: 0x518A608
	public static Task<APIResult<PvpRankAddPastRankingDummyPlayers.Types.Response>> SendAsync(PvpRankAddPastRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A6FC Offset: 0x51866FC VA: 0x518A6FC
	public static APIResult<PvpRankAddPastRankingDummyPlayers.Types.Response> SendWithAuthorize(PvpRankAddPastRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A798 Offset: 0x5186798 VA: 0x518A798
	public static Task<APIResult<PvpRankAddPastRankingDummyPlayers.Types.Response>> SendWithAuthorizeAsync(PvpRankAddPastRankingDummyPlayers.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A844 Offset: 0x5186844 VA: 0x518A844
	public static APIResult<PvpRankSetCurrentSeasonProfile.Types.Response> Send(PvpRankSetCurrentSeasonProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A8E0 Offset: 0x51868E0 VA: 0x518A8E0
	public static Task<APIResult<PvpRankSetCurrentSeasonProfile.Types.Response>> SendAsync(PvpRankSetCurrentSeasonProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518A9D4 Offset: 0x51869D4 VA: 0x518A9D4
	public static APIResult<PvpRankSetCurrentSeasonProfile.Types.Response> SendWithAuthorize(PvpRankSetCurrentSeasonProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518AA70 Offset: 0x5186A70 VA: 0x518AA70
	public static Task<APIResult<PvpRankSetCurrentSeasonProfile.Types.Response>> SendWithAuthorizeAsync(PvpRankSetCurrentSeasonProfile.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518AB1C Offset: 0x5186B1C VA: 0x518AB1C
	public static APIResult<PvpRankClearSeasonResult.Types.Response> Send(PvpRankClearSeasonResult.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518ABB8 Offset: 0x5186BB8 VA: 0x518ABB8
	public static Task<APIResult<PvpRankClearSeasonResult.Types.Response>> SendAsync(PvpRankClearSeasonResult.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518ACAC Offset: 0x5186CAC VA: 0x518ACAC
	public static APIResult<PvpRankClearSeasonResult.Types.Response> SendWithAuthorize(PvpRankClearSeasonResult.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518AD48 Offset: 0x5186D48 VA: 0x518AD48
	public static Task<APIResult<PvpRankClearSeasonResult.Types.Response>> SendWithAuthorizeAsync(PvpRankClearSeasonResult.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518ADF4 Offset: 0x5186DF4 VA: 0x518ADF4
	public static APIResult<PvpRankRequestMatchingForceBot.Types.Response> Send(PvpRankRequestMatchingForceBot.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518AE90 Offset: 0x5186E90 VA: 0x518AE90
	public static Task<APIResult<PvpRankRequestMatchingForceBot.Types.Response>> SendAsync(PvpRankRequestMatchingForceBot.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518AF84 Offset: 0x5186F84 VA: 0x518AF84
	public static APIResult<PvpRankRequestMatchingForceBot.Types.Response> SendWithAuthorize(PvpRankRequestMatchingForceBot.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518B020 Offset: 0x5187020 VA: 0x518B020
	public static Task<APIResult<PvpRankRequestMatchingForceBot.Types.Response>> SendWithAuthorizeAsync(PvpRankRequestMatchingForceBot.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class SoloBattle // TypeDefIndex: 2612
{
	// Methods

	// RVA: 0x518C010 Offset: 0x5188010 VA: 0x518C010
	public static APIResult<SoloBattleAddEventPower.Types.Response> Send(SoloBattleAddEventPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C0AC Offset: 0x51880AC VA: 0x518C0AC
	public static Task<APIResult<SoloBattleAddEventPower.Types.Response>> SendAsync(SoloBattleAddEventPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C1A0 Offset: 0x51881A0 VA: 0x518C1A0
	public static APIResult<SoloBattleAddEventPower.Types.Response> SendWithAuthorize(SoloBattleAddEventPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C23C Offset: 0x518823C VA: 0x518C23C
	public static Task<APIResult<SoloBattleAddEventPower.Types.Response>> SendWithAuthorizeAsync(SoloBattleAddEventPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Trade // TypeDefIndex: 2615
{
	// Methods

	// RVA: 0x518C448 Offset: 0x5188448 VA: 0x518C448
	public static APIResult<TradeSetPower.Types.Response> Send(TradeSetPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C4E4 Offset: 0x51884E4 VA: 0x518C4E4
	public static Task<APIResult<TradeSetPower.Types.Response>> SendAsync(TradeSetPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C5D8 Offset: 0x51885D8 VA: 0x518C5D8
	public static APIResult<TradeSetPower.Types.Response> SendWithAuthorize(TradeSetPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C674 Offset: 0x5188674 VA: 0x518C674
	public static Task<APIResult<TradeSetPower.Types.Response>> SendWithAuthorizeAsync(TradeSetPower.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C720 Offset: 0x5188720 VA: 0x518C720
	public static APIResult<TradeCreateTradeHistories.Types.Response> Send(TradeCreateTradeHistories.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C7BC Offset: 0x51887BC VA: 0x518C7BC
	public static Task<APIResult<TradeCreateTradeHistories.Types.Response>> SendAsync(TradeCreateTradeHistories.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C8B0 Offset: 0x51888B0 VA: 0x518C8B0
	public static APIResult<TradeCreateTradeHistories.Types.Response> SendWithAuthorize(TradeCreateTradeHistories.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518C94C Offset: 0x518894C VA: 0x518C94C
	public static Task<APIResult<TradeCreateTradeHistories.Types.Response>> SendWithAuthorizeAsync(TradeCreateTradeHistories.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Trophy // TypeDefIndex: 2617
{
	// Methods

	// RVA: 0x518CCB8 Offset: 0x5188CB8 VA: 0x518CCB8
	public static APIResult<TrophySet.Types.Response> Send(TrophySet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518CD54 Offset: 0x5188D54 VA: 0x518CD54
	public static Task<APIResult<TrophySet.Types.Response>> SendAsync(TrophySet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518CE48 Offset: 0x5188E48 VA: 0x518CE48
	public static APIResult<TrophySet.Types.Response> SendWithAuthorize(TrophySet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518CEE4 Offset: 0x5188EE4 VA: 0x518CEE4
	public static Task<APIResult<TrophySet.Types.Response>> SendWithAuthorizeAsync(TrophySet.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Tutorial // TypeDefIndex: 2619
{
	// Methods

	// RVA: 0x518D0F0 Offset: 0x51890F0 VA: 0x518D0F0
	public static APIResult<TutorialSetTutorialStep.Types.Response> Send(TutorialSetTutorialStep.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D18C Offset: 0x518918C VA: 0x518D18C
	public static Task<APIResult<TutorialSetTutorialStep.Types.Response>> SendAsync(TutorialSetTutorialStep.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D280 Offset: 0x5189280 VA: 0x518D280
	public static APIResult<TutorialSetTutorialStep.Types.Response> SendWithAuthorize(TutorialSetTutorialStep.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D31C Offset: 0x518931C VA: 0x518D31C
	public static Task<APIResult<TutorialSetTutorialStep.Types.Response>> SendWithAuthorizeAsync(TutorialSetTutorialStep.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Endpoint.LettuceDebugServer.Debug
public static class Webview // TypeDefIndex: 2621
{
	// Methods

	// RVA: 0x518D528 Offset: 0x5189528 VA: 0x518D528
	public static APIResult<WebviewSetLastViewed.Types.Response> Send(WebviewSetLastViewed.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D5C4 Offset: 0x51895C4 VA: 0x518D5C4
	public static Task<APIResult<WebviewSetLastViewed.Types.Response>> SendAsync(WebviewSetLastViewed.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D6B8 Offset: 0x51896B8 VA: 0x518D6B8
	public static APIResult<WebviewSetLastViewed.Types.Response> SendWithAuthorize(WebviewSetLastViewed.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }

	// RVA: 0x518D754 Offset: 0x5189754 VA: 0x518D754
	public static Task<APIResult<WebviewSetLastViewed.Types.Response>> SendWithAuthorizeAsync(WebviewSetLastViewed.Types.Request req, DeviceContext deviceContext, Nullable<RequestOptions> requestOptions) { }
}

// Namespace: Takasho.Schema.Framework
public static class DeviceContextReflection // TypeDefIndex: 5143
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x5643EE4 Offset: 0x563FEE4 VA: 0x5643EE4
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x5643F3C Offset: 0x563FF3C VA: 0x5643F3C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SerializedDeviceContext.<>c // TypeDefIndex: 5144
{
	// Fields
	public static readonly SerializedDeviceContext.<>c <>9; // 0x0

	// Methods

	// RVA: 0x5645020 Offset: 0x5641020 VA: 0x5645020
	private static void .cctor() { }

	// RVA: 0x5645088 Offset: 0x5641088 VA: 0x5645088
	public void .ctor() { }

	// RVA: 0x5645090 Offset: 0x5641090 VA: 0x5645090
	internal SerializedDeviceContext <.cctor>b__32_0() { }
}

// Namespace: Takasho.Schema.Framework
public sealed class SerializedDeviceContext : IMessage<SerializedDeviceContext>, IMessage, IEquatable<SerializedDeviceContext>, IDeepCloneable<SerializedDeviceContext>, IBufferMessage // TypeDefIndex: 5145
{
	// Fields
	private static readonly MessageParser<SerializedDeviceContext> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int AccountFieldNumber = 1;
	private string account_; // 0x18
	public const int PasswordFieldNumber = 2;
	private string password_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	public static MessageParser<SerializedDeviceContext> Parser { get; }
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	public string Account { get; set; }
	[DebuggerNonUserCode]
	public string Password { get; set; }

	// Methods

	// RVA: 0x5644684 Offset: 0x5640684 VA: 0x5644684
	public static MessageParser<SerializedDeviceContext> get_Parser() { }

	// RVA: 0x56446DC Offset: 0x56406DC VA: 0x56446DC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x56447E0 Offset: 0x56407E0 VA: 0x56447E0 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	// RVA: 0x564482C Offset: 0x564082C VA: 0x564482C
	public void .ctor() { }

	[DebuggerNonUserCode]
	// RVA: 0x5644894 Offset: 0x5640894 VA: 0x5644894
	public void .ctor(SerializedDeviceContext other) { }

	[DebuggerNonUserCode]
	// RVA: 0x56448F4 Offset: 0x56408F4 VA: 0x56448F4 Slot: 10
	public SerializedDeviceContext Clone() { }

	// RVA: 0x564494C Offset: 0x564094C VA: 0x564494C
	public string get_Account() { }

	// RVA: 0x5644954 Offset: 0x5640954 VA: 0x5644954
	public void set_Account(string value) { }

	// RVA: 0x56449D0 Offset: 0x56409D0 VA: 0x56449D0
	public string get_Password() { }

	// RVA: 0x56449D8 Offset: 0x56409D8 VA: 0x56449D8
	public void set_Password(string value) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644A54 Offset: 0x5640A54 VA: 0x5644A54 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644AB8 Offset: 0x5640AB8 VA: 0x5644AB8 Slot: 9
	public bool Equals(SerializedDeviceContext other) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644B2C Offset: 0x5640B2C VA: 0x5644B2C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	// RVA: 0x5644BAC Offset: 0x5640BAC VA: 0x5644BAC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	// RVA: 0x5644C04 Offset: 0x5640C04 VA: 0x5644C04 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644C24 Offset: 0x5640C24 VA: 0x5644C24 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644CC0 Offset: 0x5640CC0 VA: 0x5644CC0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	// RVA: 0x5644D90 Offset: 0x5640D90 VA: 0x5644D90 Slot: 4
	public void MergeFrom(SerializedDeviceContext other) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644E0C Offset: 0x5640E0C VA: 0x5644E0C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	// RVA: 0x5644E2C Offset: 0x5640E2C VA: 0x5644E2C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x5644F08 Offset: 0x5640F08 VA: 0x5644F08
	private static void .cctor() { }
}

// Namespace: Lettuce.Presentation.Activity.Common
public class CommonUIDataUsePresenter : ICommonUIDataUseTransaction, IDisposable // TypeDefIndex: 14346
{
	// Fields
	private readonly IWebViewSystem _webViewSystem; // 0x10
	private readonly IErrorReporter _errorReporter; // 0x18
	private readonly IPlayerPreferenceService _playerPreferenceService; // 0x20
	private readonly CountryService _countryService; // 0x28
	private readonly EulaPpDataUseService _eulaPpDataUseService; // 0x30
	private readonly ITakashoDeviceContextService _deviceContextService; // 0x38
	private readonly CommonUIDataUseDialogPresenter _dialogPresenter; // 0x40
	private LtUIDef.UILayerType _layerType; // 0x48
	private Action _onClose; // 0x50
	private bool _usedSelfCacheData; // 0x58
	private readonly IPlayerSettingService _playerSettingService; // 0x60
	private readonly ServiceLocator _locator; // 0x68
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <IsUseOfLoginDataChanged>k__BackingField; // 0x71

	// Properties
	private bool IsCompleted { set; }
	public bool IsUseOfLoginDataChanged { get; set; }

	// Methods

	[Inject]
	// RVA: 0x3FDAEA0 Offset: 0x3FD6EA0 VA: 0x3FDAEA0
	public void .ctor(IWebViewSystem webViewSystem, EulaPpDataUseService eulaPpDataUseService, IErrorReporter errorReporter, ITakashoServiceFacade takashoServiceFacade, IPlayerPreferenceService playerPreferenceService, CountryService countryService, IServiceLocator parentLocator, IPlayerSettingService playerSettingService) { }

	[CompilerGenerated]
	// RVA: 0x3FDB0C4 Offset: 0x3FD70C4 VA: 0x3FDB0C4
	private void set_IsCompleted(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3FDB0CC Offset: 0x3FD70CC VA: 0x3FDB0CC
	public bool get_IsUseOfLoginDataChanged() { }

	[CompilerGenerated]
	// RVA: 0x3FDB0D4 Offset: 0x3FD70D4 VA: 0x3FDB0D4
	private void set_IsUseOfLoginDataChanged(bool value) { }

	[AsyncStateMachine(typeof(CommonUIDataUsePresenter.<Start>d__21))]
	// RVA: 0x3FD85CC Offset: 0x3FD45CC VA: 0x3FD85CC
	public UniTask Start(Action onClose, LtUIDef.UILayerType layerType, bool usedSelfCacheData, LtUIDef.ShowType dialogShowType) { }

	[AsyncStateMachine(typeof(CommonUIDataUsePresenter.<Lettuce-Presentation-Activity-Common-ICommonUIDataUseTransaction-OpenPrivacyPolicyAsync>d__22))]
	// RVA: 0x3FDB0DC Offset: 0x3FD70DC VA: 0x3FDB0DC Slot: 4
	private UniTask Lettuce.Presentation.Activity.Common.ICommonUIDataUseTransaction.OpenPrivacyPolicyAsync() { }

	[AsyncStateMachine(typeof(CommonUIDataUsePresenter.<Lettuce-Presentation-Activity-Common-ICommonUIDataUseTransaction-CloseAsync>d__23))]
	// RVA: 0x3FDB180 Offset: 0x3FD7180 VA: 0x3FDB180 Slot: 5
	private UniTask Lettuce.Presentation.Activity.Common.ICommonUIDataUseTransaction.CloseAsync() { }

	// RVA: 0x3FDB228 Offset: 0x3FD7228 VA: 0x3FDB228
	private void ChangeErrorReporterBehavior(bool enableErrorReport) { }

	// RVA: 0x3FDB514 Offset: 0x3FD7514 VA: 0x3FDB514 Slot: 6
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
private struct TakashoAuthService.<DoAuth>d__17 : IAsyncStateMachine // TypeDefIndex: 22695
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<TakashoAuthResult> <>t__builder; // 0x8
	public TraceScope parentScope; // 0x20
	public TakashoAuthService <>4__this; // 0x28
	public string idToken; // 0x30
	private TraceScope <_>5__2; // 0x38
	private DeviceContext <context>5__3; // 0x40
	private TaskAwaiter<AuthorizeResult> <>u__1; // 0x48

	// Methods

	// RVA: 0x49AC51C Offset: 0x49A851C VA: 0x49AC51C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x49ACEAC Offset: 0x49A8EAC VA: 0x49ACEAC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Lettuce.Takasho.Impl.Service
public class TakashoAuthService : ITakashoAuthService // TypeDefIndex: 22697
{
	// Fields
	private readonly ITakashoSystemService _takashoSystemService; // 0x10
	private readonly TakashoSpecialErrorHandler _specialErrorHandler; // 0x18
	private string _serverUri; // 0x20
	private string _commonKey; // 0x28
	private string _version; // 0x30
	private string _buildVersion; // 0x38
	private bool _isNeedWaitAuth; // 0x40
	private bool _isNeedRetry; // 0x41
	private Func<UniTask<string>> _getLatestIdTokenAsyncFunc; // 0x48
	[CompilerGenerated]
	private bool <IsLoggedIn>k__BackingField; // 0x50

	// Properties
	private bool IsLoggedIn { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49ABB8C Offset: 0x49A7B8C VA: 0x49ABB8C
	private void set_IsLoggedIn(bool value) { }

	// RVA: 0x49ABB94 Offset: 0x49A7B94 VA: 0x49ABB94
	public void .ctor(ITakashoSystemService takashoSystemService, TakashoSpecialErrorHandler specialErrorHandler) { }

	// RVA: 0x49ABBD8 Offset: 0x49A7BD8 VA: 0x49ABBD8
	public void SetConfiguration(string serverUri, string commonKey, string version, string buildVersion) { }

	// RVA: 0x49ABC38 Offset: 0x49A7C38 VA: 0x49ABC38 Slot: 5
	public void SetLatestIdTokenGetAsyncFunc(Func<UniTask<string>> getLatestIdTokenAsyncFunc) { }

	[AsyncStateMachine(typeof(TakashoAuthService.<ExecuteAuth>d__16))]
	// RVA: 0x49ABC40 Offset: 0x49A7C40 VA: 0x49ABC40 Slot: 4
	public UniTask<TakashoAuthResult> ExecuteAuth(string idToken) { }

	[AsyncStateMachine(typeof(TakashoAuthService.<DoAuth>d__17))]
	// RVA: 0x49ABD74 Offset: 0x49A7D74 VA: 0x49ABD74
	private UniTask<TakashoAuthResult> DoAuth(string idToken, TraceScope parentScope) { }

	// RVA: 0x49ABEC0 Offset: 0x49A7EC0 VA: 0x49ABEC0
	private void InitializeTakashoGretelContext() { }

	// RVA: 0x49ABEC4 Offset: 0x49A7EC4 VA: 0x49ABEC4
	private ValueTuple<ILtError, ILtError> ProcessError(Error error, LtTakashoEndPointCode endPointCode) { }

	// RVA: 0x49AC078 Offset: 0x49A8078 VA: 0x49AC078 Slot: 6
	public void OnRetry() { }

	// RVA: 0x49AC084 Offset: 0x49A8084 VA: 0x49AC084
	private IAuthorizer CreateAuthorizer(string idToken) { }

	// RVA: 0x49AC144 Offset: 0x49A8144 VA: 0x49AC144
	private static Platform GetDefaultPlatform() { }

	// RVA: 0x49AC19C Offset: 0x49A819C VA: 0x49AC19C
	private static string GetDefaultDeviceModel() { }

	// RVA: 0x49AC1A4 Offset: 0x49A81A4 VA: 0x49AC1A4
	private static Os GetDefaultOs() { }

	// RVA: 0x49AC388 Offset: 0x49A8388 VA: 0x49AC388
	private static string GetDefaultOsDetail() { }

	// RVA: 0x49AC390 Offset: 0x49A8390 VA: 0x49AC390
	private static string GetDeviceContextStorePath() { }
}

// Namespace: Lettuce.Takasho.Impl.Service
public class TakashoDeviceContextService : ITakashoDeviceContextService // TypeDefIndex: 22735
{
	// Methods

	// RVA: 0x49B9294 Offset: 0x49B5294 VA: 0x49B9294 Slot: 4
	public string GetPlayerId() { }

	// RVA: 0x49B92F4 Offset: 0x49B52F4 VA: 0x49B92F4 Slot: 6
	public string GetStoredFileName() { }

	// RVA: 0x49B9334 Offset: 0x49B5334 VA: 0x49B9334 Slot: 5
	public void ResetDeviceContext() { }

	// RVA: 0x49B947C Offset: 0x49B547C VA: 0x49B947C
	public void .ctor() { }
}

// Namespace: Lettuce.Takasho.Impl.Service
public class TakashoServiceFacade : ITakashoServiceFacade, IDisposable // TypeDefIndex: 22838
{
	// Fields
	private readonly IServerConnectionManager _serverConnectionManager; // 0x10
	private readonly TakashoAuthService _authService; // 0x18
	private readonly TakashoDeviceContextService _deviceContextService; // 0x20
	private readonly TakashoFeedService _feedService; // 0x28
	private readonly TakashoCardService _cardService; // 0x30
	private readonly TakashoMissionService _missionService; // 0x38
	private readonly TakashoTrophyService _trophyService; // 0x40
	private readonly TakashoTutorialService _tutorialService; // 0x48
	private readonly TakashoActionService _actionService; // 0x50
	private readonly TakashoPresentBoxService _presentBoxService; // 0x58
	private readonly TakashoInventoryService _inventoryService; // 0x60
	private readonly TakashoPackService _packService; // 0x68
	private readonly TakashoPackShopService _packShopService; // 0x70
	private readonly TakashoCardSkinService _cardSkinService; // 0x78
	private readonly TakashoPvPCasualService _pvpCasualService; // 0x80
	private readonly TakashoPvPEventService _pvpEventService; // 0x88
	private readonly ITakashoAlbumService _albumService; // 0x90
	private readonly TakashoCollectionBoardService _collectionBoardService; // 0x98
	private readonly TakashoSystemService _systemService; // 0xA0
	private readonly ITakashoCommonResponseService _commonResponseService; // 0xA8
	private readonly ITakashoPlayerStorageService _playerStorageService; // 0xB0
	private readonly ITakashoPlayerResourcesService _playerResourcesService; // 0xB8
	private readonly ITakashoSoloBattleService _soloBattleService; // 0xC0
	private readonly ITakashoFriendService _friendService; // 0xC8
	private readonly ITakashoDeckService _deckService; // 0xD0
	private readonly ITakashoItemShopService _itemShopService; // 0xD8
	private readonly ITakashoPlayerLevelService _playerLevelService; // 0xE0
	private readonly ITakashoPlayerProfileService _playerProfileService; // 0xE8
	private readonly ITakashoCollectionService _collectionService; // 0xF0
	private readonly ITakashoPlayerSettingService _playerSettingService; // 0xF8
	private readonly ITakashoMasterAndAssetRevisionService _masterAndAssetRevisionService; // 0x100
	private readonly ITakashoAnalyticsLogService _analyticsLogService; // 0x108
	private readonly ITakashoFaveService _faveService; // 0x110
	private readonly ITakashoNotificationService _notificationService; // 0x118
	private readonly ITakashoShopService _shopService; // 0x120
	private readonly ITakashoWebviewService _webviewService; // 0x128
	private readonly TakashoThankRewardService _thankRewardService; // 0x130
	private readonly TakashoPlayerService _playerService; // 0x138
	private readonly TakashoSubscriptionService _subscriptionService; // 0x140
	private readonly TakashoTradeService _tradeService; // 0x148
	private readonly TakashoPvPRankService _pvpRankService; // 0x150
	private readonly ITakashoConnectionParametersService _connectionParametersService; // 0x158
	private readonly TakashoSpecialErrorHandler _specialErrorHandler; // 0x160

	// Properties
	public ITakashoAuthService AuthService { get; }
	public ITakashoDeviceContextService DeviceContextService { get; }
	public ITakashoFeedService FeedService { get; }
	public ITakashoCardService CardService { get; }
	public ITakashoMissionService MissionService { get; }
	public ITakashoTrophyService TrophyService { get; }
	public ITakashoTutorialService TutorialService { get; }
	public ITakashoActionService ActionService { get; }
	public ITakashoPresentBoxService PresentBoxService { get; }
	public ITakashoPackService PackService { get; }
	public ITakashoPackShopService PackShopService { get; }
	public ITakashoCardSkinService CardSkinService { get; }
	public ITakashoPvPCasualService PvPCasualService { get; }
	public ITakashoPvPEventService PvPEventService { get; }
	public ITakashoAlbumService AlbumService { get; }
	public ITakashoCollectionBoardService CollectionBoardService { get; }
	public ITakashoSystemService SystemService { get; }
	public ITakashoCommonResponseService CommonResponseService { get; }
	public ITakashoPlayerStorageService PlayerStorageService { get; }
	public ITakashoPlayerResourcesService PlayerResourcesService { get; }
	public ITakashoSoloBattleService SoloBattleService { get; }
	public ITakashoFriendService FriendService { get; }
	public ITakashoDeckService DeckService { get; }
	public ITakashoItemShopService ItemShopService { get; }
	public ITakashoPlayerLevelService PlayerLevelService { get; }
	public ITakashoPlayerProfileService PlayerProfileService { get; }
	public ITakashoCollectionService CollectionService { get; }
	public ITakashoPlayerSettingService PlayerSettingService { get; }
	public ITakashoMasterAndAssetRevisionService MasterAndAssetRevisionService { get; }
	public ITakashoAnalyticsLogService AnalyticsLogService { get; }
	public ITakashoFaveService FaveService { get; }
	public ITakashoNotificationService NotificationService { get; }
	public ITakashoShopService ShopService { get; }
	public ITakashoWebviewService WebviewService { get; }
	public ITakashoThankRewardService ThankRewardService { get; }
	public ITakashoPlayerService PlayerService { get; }
	public ITakashoSubscriptionService SubscriptionService { get; }
	public ITakashoTradeService TradeService { get; }
	public ITakashoPvPRankService PvPRankService { get; }

	// Methods

	// RVA: 0x49D93E8 Offset: 0x49D53E8 VA: 0x49D93E8 Slot: 4
	public ITakashoAuthService get_AuthService() { }

	// RVA: 0x49D93F0 Offset: 0x49D53F0 VA: 0x49D93F0 Slot: 6
	public ITakashoDeviceContextService get_DeviceContextService() { }

	// RVA: 0x49D93F8 Offset: 0x49D53F8 VA: 0x49D93F8 Slot: 7
	public ITakashoFeedService get_FeedService() { }

	// RVA: 0x49D9400 Offset: 0x49D5400 VA: 0x49D9400 Slot: 8
	public ITakashoCardService get_CardService() { }

	// RVA: 0x49D9408 Offset: 0x49D5408 VA: 0x49D9408 Slot: 9
	public ITakashoMissionService get_MissionService() { }

	// RVA: 0x49D9410 Offset: 0x49D5410 VA: 0x49D9410 Slot: 10
	public ITakashoTrophyService get_TrophyService() { }

	// RVA: 0x49D9418 Offset: 0x49D5418 VA: 0x49D9418 Slot: 11
	public ITakashoTutorialService get_TutorialService() { }

	// RVA: 0x49D9420 Offset: 0x49D5420 VA: 0x49D9420 Slot: 12
	public ITakashoActionService get_ActionService() { }

	// RVA: 0x49D9428 Offset: 0x49D5428 VA: 0x49D9428 Slot: 13
	public ITakashoPresentBoxService get_PresentBoxService() { }

	// RVA: 0x49D9430 Offset: 0x49D5430 VA: 0x49D9430 Slot: 14
	public ITakashoPackService get_PackService() { }

	// RVA: 0x49D9438 Offset: 0x49D5438 VA: 0x49D9438 Slot: 15
	public ITakashoPackShopService get_PackShopService() { }

	// RVA: 0x49D9440 Offset: 0x49D5440 VA: 0x49D9440 Slot: 16
	public ITakashoCardSkinService get_CardSkinService() { }

	// RVA: 0x49D9448 Offset: 0x49D5448 VA: 0x49D9448 Slot: 17
	public ITakashoPvPCasualService get_PvPCasualService() { }

	// RVA: 0x49D9450 Offset: 0x49D5450 VA: 0x49D9450 Slot: 18
	public ITakashoPvPEventService get_PvPEventService() { }

	// RVA: 0x49D9458 Offset: 0x49D5458 VA: 0x49D9458 Slot: 19
	public ITakashoAlbumService get_AlbumService() { }

	// RVA: 0x49D9460 Offset: 0x49D5460 VA: 0x49D9460 Slot: 20
	public ITakashoCollectionBoardService get_CollectionBoardService() { }

	// RVA: 0x49D9468 Offset: 0x49D5468 VA: 0x49D9468 Slot: 21
	public ITakashoSystemService get_SystemService() { }

	// RVA: 0x49D9470 Offset: 0x49D5470 VA: 0x49D9470 Slot: 22
	public ITakashoCommonResponseService get_CommonResponseService() { }

	// RVA: 0x49D9478 Offset: 0x49D5478 VA: 0x49D9478 Slot: 5
	public ITakashoPlayerStorageService get_PlayerStorageService() { }

	// RVA: 0x49D9480 Offset: 0x49D5480 VA: 0x49D9480 Slot: 23
	public ITakashoPlayerResourcesService get_PlayerResourcesService() { }

	// RVA: 0x49D9488 Offset: 0x49D5488 VA: 0x49D9488 Slot: 24
	public ITakashoSoloBattleService get_SoloBattleService() { }

	// RVA: 0x49D9490 Offset: 0x49D5490 VA: 0x49D9490 Slot: 25
	public ITakashoFriendService get_FriendService() { }

	// RVA: 0x49D9498 Offset: 0x49D5498 VA: 0x49D9498 Slot: 26
	public ITakashoDeckService get_DeckService() { }

	// RVA: 0x49D94A0 Offset: 0x49D54A0 VA: 0x49D94A0 Slot: 27
	public ITakashoItemShopService get_ItemShopService() { }

	// RVA: 0x49D94A8 Offset: 0x49D54A8 VA: 0x49D94A8 Slot: 28
	public ITakashoPlayerLevelService get_PlayerLevelService() { }

	// RVA: 0x49D94B0 Offset: 0x49D54B0 VA: 0x49D94B0 Slot: 29
	public ITakashoPlayerProfileService get_PlayerProfileService() { }

	// RVA: 0x49D94B8 Offset: 0x49D54B8 VA: 0x49D94B8 Slot: 30
	public ITakashoCollectionService get_CollectionService() { }

	// RVA: 0x49D94C0 Offset: 0x49D54C0 VA: 0x49D94C0 Slot: 31
	public ITakashoPlayerSettingService get_PlayerSettingService() { }

	// RVA: 0x49D94C8 Offset: 0x49D54C8 VA: 0x49D94C8 Slot: 32
	public ITakashoMasterAndAssetRevisionService get_MasterAndAssetRevisionService() { }

	// RVA: 0x49D94D0 Offset: 0x49D54D0 VA: 0x49D94D0 Slot: 33
	public ITakashoAnalyticsLogService get_AnalyticsLogService() { }

	// RVA: 0x49D94D8 Offset: 0x49D54D8 VA: 0x49D94D8 Slot: 34
	public ITakashoFaveService get_FaveService() { }

	// RVA: 0x49D94E0 Offset: 0x49D54E0 VA: 0x49D94E0 Slot: 35
	public ITakashoNotificationService get_NotificationService() { }

	// RVA: 0x49D94E8 Offset: 0x49D54E8 VA: 0x49D94E8 Slot: 36
	public ITakashoShopService get_ShopService() { }

	// RVA: 0x49D94F0 Offset: 0x49D54F0 VA: 0x49D94F0 Slot: 37
	public ITakashoWebviewService get_WebviewService() { }

	// RVA: 0x49D94F8 Offset: 0x49D54F8 VA: 0x49D94F8 Slot: 38
	public ITakashoThankRewardService get_ThankRewardService() { }

	// RVA: 0x49D9500 Offset: 0x49D5500 VA: 0x49D9500 Slot: 39
	public ITakashoPlayerService get_PlayerService() { }

	// RVA: 0x49D9508 Offset: 0x49D5508 VA: 0x49D9508 Slot: 40
	public ITakashoSubscriptionService get_SubscriptionService() { }

	// RVA: 0x49D9510 Offset: 0x49D5510 VA: 0x49D9510 Slot: 41
	public ITakashoTradeService get_TradeService() { }

	// RVA: 0x49D9518 Offset: 0x49D5518 VA: 0x49D9518 Slot: 42
	public ITakashoPvPRankService get_PvPRankService() { }

	[Inject]
	// RVA: 0x49D9520 Offset: 0x49D5520 VA: 0x49D9520
	public void .ctor(IActivityFacade activitySystem, ILtApiClientConnectionNotifyHelper connectionNotifyHelper, ILtApiErrorNotifier errorNotifier) { }

	// RVA: 0x49DA0C8 Offset: 0x49D60C8 VA: 0x49DA0C8 Slot: 43
	public void SetConfiguration(string serverUri, string commonKey, string version, string buildVersion) { }

	// RVA: 0x49DA0E4 Offset: 0x49D60E4 VA: 0x49DA0E4 Slot: 44
	public void OnUpdate() { }

	// RVA: 0x49DA1FC Offset: 0x49D61FC VA: 0x49DA1FC Slot: 45
	public bool HandleSpecialError(ILtSystemError error, out ILtError specialError) { }

	// RVA: 0x49DA2F4 Offset: 0x49D62F4 VA: 0x49DA2F4 Slot: 46
	public bool IsAbortedAll() { }

	// RVA: 0x49DA398 Offset: 0x49D6398 VA: 0x49DA398 Slot: 47
	public void ForceAbortAll() { }

	// RVA: 0x49DA43C Offset: 0x49D643C VA: 0x49DA43C Slot: 48
	public void Dispose() { }
}

// Namespace: Lettuce.Takasho.Core
public interface ITakashoServiceFacade // TypeDefIndex: 23731
{
	// Properties
	public abstract ITakashoAuthService AuthService { get; }
	public abstract ITakashoPlayerStorageService PlayerStorageService { get; }
	public abstract ITakashoDeviceContextService DeviceContextService { get; }
	public abstract ITakashoFeedService FeedService { get; }
	public abstract ITakashoCardService CardService { get; }
	public abstract ITakashoMissionService MissionService { get; }
	public abstract ITakashoTrophyService TrophyService { get; }
	public abstract ITakashoTutorialService TutorialService { get; }
	public abstract ITakashoActionService ActionService { get; }
	public abstract ITakashoPresentBoxService PresentBoxService { get; }
	public abstract ITakashoPackService PackService { get; }
	public abstract ITakashoPackShopService PackShopService { get; }
	public abstract ITakashoCardSkinService CardSkinService { get; }
	public abstract ITakashoPvPCasualService PvPCasualService { get; }
	public abstract ITakashoPvPEventService PvPEventService { get; }
	public abstract ITakashoAlbumService AlbumService { get; }
	public abstract ITakashoCollectionBoardService CollectionBoardService { get; }
	public abstract ITakashoSystemService SystemService { get; }
	public abstract ITakashoCommonResponseService CommonResponseService { get; }
	public abstract ITakashoPlayerResourcesService PlayerResourcesService { get; }
	public abstract ITakashoSoloBattleService SoloBattleService { get; }
	public abstract ITakashoFriendService FriendService { get; }
	public abstract ITakashoDeckService DeckService { get; }
	public abstract ITakashoItemShopService ItemShopService { get; }
	public abstract ITakashoPlayerLevelService PlayerLevelService { get; }
	public abstract ITakashoPlayerProfileService PlayerProfileService { get; }
	public abstract ITakashoCollectionService CollectionService { get; }
	public abstract ITakashoPlayerSettingService PlayerSettingService { get; }
	public abstract ITakashoMasterAndAssetRevisionService MasterAndAssetRevisionService { get; }
	public abstract ITakashoAnalyticsLogService AnalyticsLogService { get; }
	public abstract ITakashoFaveService FaveService { get; }
	public abstract ITakashoNotificationService NotificationService { get; }
	public abstract ITakashoShopService ShopService { get; }
	public abstract ITakashoWebviewService WebviewService { get; }
	public abstract ITakashoThankRewardService ThankRewardService { get; }
	public abstract ITakashoPlayerService PlayerService { get; }
	public abstract ITakashoSubscriptionService SubscriptionService { get; }
	public abstract ITakashoTradeService TradeService { get; }
	public abstract ITakashoPvPRankService PvPRankService { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITakashoAuthService get_AuthService();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ITakashoPlayerStorageService get_PlayerStorageService();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ITakashoDeviceContextService get_DeviceContextService();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ITakashoFeedService get_FeedService();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ITakashoCardService get_CardService();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ITakashoMissionService get_MissionService();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ITakashoTrophyService get_TrophyService();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract ITakashoTutorialService get_TutorialService();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract ITakashoActionService get_ActionService();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ITakashoPresentBoxService get_PresentBoxService();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ITakashoPackService get_PackService();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ITakashoPackShopService get_PackShopService();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ITakashoCardSkinService get_CardSkinService();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ITakashoPvPCasualService get_PvPCasualService();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ITakashoPvPEventService get_PvPEventService();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract ITakashoAlbumService get_AlbumService();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract ITakashoCollectionBoardService get_CollectionBoardService();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ITakashoSystemService get_SystemService();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract ITakashoCommonResponseService get_CommonResponseService();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract ITakashoPlayerResourcesService get_PlayerResourcesService();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract ITakashoSoloBattleService get_SoloBattleService();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ITakashoFriendService get_FriendService();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract ITakashoDeckService get_DeckService();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ITakashoItemShopService get_ItemShopService();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ITakashoPlayerLevelService get_PlayerLevelService();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract ITakashoPlayerProfileService get_PlayerProfileService();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract ITakashoCollectionService get_CollectionService();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract ITakashoPlayerSettingService get_PlayerSettingService();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract ITakashoMasterAndAssetRevisionService get_MasterAndAssetRevisionService();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract ITakashoAnalyticsLogService get_AnalyticsLogService();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract ITakashoFaveService get_FaveService();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract ITakashoNotificationService get_NotificationService();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract ITakashoShopService get_ShopService();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract ITakashoWebviewService get_WebviewService();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ITakashoThankRewardService get_ThankRewardService();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract ITakashoPlayerService get_PlayerService();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract ITakashoSubscriptionService get_SubscriptionService();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract ITakashoTradeService get_TradeService();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract ITakashoPvPRankService get_PvPRankService();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void SetConfiguration(string serverUri, string commonKey, string version, string buildVersion);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void OnUpdate();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool HandleSpecialError(ILtSystemError error, out ILtError specialError);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract bool IsAbortedAll();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void ForceAbortAll();
}

// Namespace: Lettuce.Takasho.Core
public interface ITakashoDeviceContextService // TypeDefIndex: 23744
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetPlayerId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ResetDeviceContext();
}

// Namespace: Lettuce.Presentation.Profile
public class ProfileUITopViewModel // TypeDefIndex: 25593
{
	// Fields
	private readonly ITrophyService _trophyService; // 0x10
	private readonly IOneWordService _oneWordService; // 0x18
	private readonly IPlayerIconSettingService _playerIconSettingService; // 0x20
	private readonly IBattleRecordService _battleRecordService; // 0x28
	private readonly IEmblemService _emblemService; // 0x30
	private readonly IMyBestService _myBestService; // 0x38
	private readonly ICollectionProgressService _collectionProgressService; // 0x40
	private readonly IPlayerStatusService _playerStatusService; // 0x48
	private readonly IMissionSystem _missionSystem; // 0x50
	private readonly IPlayerProfileService _playerProfileService; // 0x58
	private readonly ITakashoDeviceContextService _deviceContextService; // 0x60
	private readonly ICollectionService _collectionService; // 0x68
	private readonly IPlayerFlaggedCardService _playerFlaggedCardService; // 0x70
	[CompilerGenerated]
	private ProfileUITopUserDetailViewModel <UserDetailViewModel>k__BackingField; // 0x78
	[CompilerGenerated]
	private IList<ProfileUITopRecordListViewModel> <RecordListViewModels>k__BackingField; // 0x80
	[CompilerGenerated]
	private IEnumerable<TrophyData> <NewCompleteTrophyList>k__BackingField; // 0x88
	[CompilerGenerated]
	private ItemAcquisitionResultValue <ItemAcquisitionResult>k__BackingField; // 0x90

	// Properties
	public ProfileUITopUserDetailViewModel UserDetailViewModel { get; set; }
	public IList<ProfileUITopRecordListViewModel> RecordListViewModels { get; set; }
	public IEnumerable<TrophyData> NewCompleteTrophyList { get; set; }
	public ItemAcquisitionResultValue ItemAcquisitionResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x480EB98 Offset: 0x480AB98 VA: 0x480EB98
	public ProfileUITopUserDetailViewModel get_UserDetailViewModel() { }

	[CompilerGenerated]
	// RVA: 0x480EBA0 Offset: 0x480ABA0 VA: 0x480EBA0
	private void set_UserDetailViewModel(ProfileUITopUserDetailViewModel value) { }

	[CompilerGenerated]
	// RVA: 0x480EBA8 Offset: 0x480ABA8 VA: 0x480EBA8
	public IList<ProfileUITopRecordListViewModel> get_RecordListViewModels() { }

	[CompilerGenerated]
	// RVA: 0x480EBB0 Offset: 0x480ABB0 VA: 0x480EBB0
	private void set_RecordListViewModels(IList<ProfileUITopRecordListViewModel> value) { }

	[CompilerGenerated]
	// RVA: 0x480EBB8 Offset: 0x480ABB8 VA: 0x480EBB8
	public IEnumerable<TrophyData> get_NewCompleteTrophyList() { }

	[CompilerGenerated]
	// RVA: 0x480EBC0 Offset: 0x480ABC0 VA: 0x480EBC0
	public void set_NewCompleteTrophyList(IEnumerable<TrophyData> value) { }

	[CompilerGenerated]
	// RVA: 0x480EBC8 Offset: 0x480ABC8 VA: 0x480EBC8
	public ItemAcquisitionResultValue get_ItemAcquisitionResult() { }

	[CompilerGenerated]
	// RVA: 0x480EBD0 Offset: 0x480ABD0 VA: 0x480EBD0
	public void set_ItemAcquisitionResult(ItemAcquisitionResultValue value) { }

	[Inject]
	// RVA: 0x480EBD8 Offset: 0x480ABD8 VA: 0x480EBD8
	public void .ctor(ITakashoServiceFacade takashoServiceFacade, ITrophyService trophyService, IOneWordService oneWordService, IPlayerIconSettingService playerIconSettingService, IBattleRecordService battleRecordService, IEmblemService emblemService, IMyBestService myBestService, ICollectionProgressService collectionProgressService, IPlayerStatusService playerStatusService, IMissionSystem missionSystem, IPlayerProfileService playerProfileService, ICollectionService collectionService, IPlayerFlaggedCardService playerFlaggedCardService) { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<CreateSelfUserDetailViewModel>d__30))]
	// RVA: 0x480EDB4 Offset: 0x480ADB4 VA: 0x480EDB4
	private UniTask<ProfileUITopUserDetailViewModel> CreateSelfUserDetailViewModel() { }

	// RVA: 0x480EED4 Offset: 0x480AED4 VA: 0x480EED4
	private static ProfileUITopFriendState GetFriendState(PlayerProfileFriendStatus status) { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<CreateOtherUserDetailViewModel>d__32))]
	// RVA: 0x480EEE4 Offset: 0x480AEE4 VA: 0x480EEE4
	private UniTask<ProfileUITopUserDetailViewModel> CreateOtherUserDetailViewModel(string playerId) { }

	// RVA: 0x480F020 Offset: 0x480B020 VA: 0x480F020
	private static IList<ProfileUITopRecordListViewModel> ConvertTrophyDataToViewModel(IList<TrophyData> trophyDataList) { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<CreateSelfUserRecordListViewModels>d__34))]
	// RVA: 0x480F13C Offset: 0x480B13C VA: 0x480F13C
	private UniTask<ValueTuple<IList<ProfileUITopRecordListViewModel>, List<TrophyData>, ItemAcquisitionResultValue>> CreateSelfUserRecordListViewModels() { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<CreateOtherUserRecordListViewModels>d__35))]
	// RVA: 0x480F260 Offset: 0x480B260 VA: 0x480F260
	private UniTask<IList<ProfileUITopRecordListViewModel>> CreateOtherUserRecordListViewModels(string playerId) { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<FetchViewModelForSelf>d__36))]
	// RVA: 0x480F390 Offset: 0x480B390 VA: 0x480F390
	public UniTask FetchViewModelForSelf() { }

	[AsyncStateMachine(typeof(ProfileUITopViewModel.<FetchViewModelForOther>d__37))]
	// RVA: 0x480F438 Offset: 0x480B438 VA: 0x480F438
	public UniTask FetchViewModelForOther(string playerId) { }

	// RVA: 0x480F504 Offset: 0x480B504 VA: 0x480F504
	public ProfileUITrophyViewModel GetTrophyViewModelByTrophyId(string trophyId) { }
}

// Namespace: Lettuce.Presentation.Title.Service
public class BootErrorReporterSetupService // TypeDefIndex: 32406
{
	// Fields
	private readonly EulaPpDataUseService _eulaPpDataUseService; // 0x10
	private readonly IErrorReporter _errorReporter; // 0x18
	private readonly ITakashoDeviceContextService _deviceContextService; // 0x20
	private readonly IPlayerPreferenceService _playerPreferenceService; // 0x28
	private bool _isAlreadySetupDone; // 0x30

	// Methods

	[Inject]
	// RVA: 0x3B74F44 Offset: 0x3B70F44 VA: 0x3B74F44
	public void .ctor(EulaPpDataUseService eulaPpDataUseService, IErrorReporter errorReporter, LtUserPrefsFacade userPrefsFacade, ITakashoServiceFacade takashoServiceFacade, IPlayerPreferenceService playerPreferenceService) { }

	// RVA: 0x3B75050 Offset: 0x3B71050 VA: 0x3B75050
	public void SetupErrorReporter() { }
}

// Namespace: 
[CompilerGenerated]
private struct LtAuthorizer.<Authorize>d__7 : IAsyncStateMachine // TypeDefIndex: 37091
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AuthorizeResult> <>t__builder; // 0x8
	public LtAuthorizer <>4__this; // 0x20
	public DeviceContext deviceContext; // 0x28
	private UniTask.Awaiter<AuthorizeResult> <>u__1; // 0x30

	// Methods

	// RVA: 0x499E02C Offset: 0x499A02C VA: 0x499E02C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x499E310 Offset: 0x499A310 VA: 0x499E310 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct LtAuthorizer.<AuthorizeInternal>d__8 : IAsyncStateMachine // TypeDefIndex: 37092
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<AuthorizeResult> <>t__builder; // 0x8
	public DeviceContext deviceContext; // 0x38
	public LtAuthorizer <>4__this; // 0x40
	private string <deviceAccount>5__2; // 0x48
	private LtSystemPlatformType <platform>5__3; // 0x50
	private UniTask.Awaiter<string> <>u__1; // 0x58
	private UniTask.Awaiter<TakashoSystemAuthorizeResult> <>u__2; // 0x70

	// Methods

	// RVA: 0x499E38C Offset: 0x499A38C VA: 0x499E38C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x499EB00 Offset: 0x499AB00 VA: 0x499EB00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Lettuce.Takasho.Impl.ApiCaller
public class LtAuthorizer : IAuthorizer // TypeDefIndex: 37093
{
	// Fields
	private readonly ITakashoSystemService _takashoSystemService; // 0x10
	private readonly Platform _platform; // 0x18
	private readonly Func<UniTask<string>> _getLatestIdTokenAsyncFunc; // 0x20
	private string _idToken; // 0x28
	private bool _isFirstAuthorize; // 0x30

	// Methods

	// RVA: 0x499DC98 Offset: 0x4999C98 VA: 0x499DC98
	public void .ctor(ITakashoSystemService takashoSystemService, string initialIdToken, Platform platform, Func<UniTask<string>> getLatestIdTokenAsyncFunc) { }

	// RVA: 0x499DD18 Offset: 0x4999D18 VA: 0x499DD18 Slot: 4
	public bool IsNeedAuthorize(ErrorCode errorCode) { }

	[AsyncStateMachine(typeof(LtAuthorizer.<Authorize>d__7))]
	// RVA: 0x499DDC0 Offset: 0x4999DC0 VA: 0x499DDC0 Slot: 5
	public Task<AuthorizeResult> Authorize(DeviceContext deviceContext) { }

	[AsyncStateMachine(typeof(LtAuthorizer.<AuthorizeInternal>d__8))]
	// RVA: 0x499DEEC Offset: 0x4999EEC VA: 0x499DEEC
	private UniTask<AuthorizeResult> AuthorizeInternal(DeviceContext deviceContext) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TakashoApiCaller.<>c__DisplayClass0_0<TRequest, TResponse> // TypeDefIndex: 37102
{
	// Fields
	public Func<TRequest, DeviceContext, Nullable<RequestOptions>, APIResult<TResponse>> api; // 0x0
	public TRequest request; // 0x0
	public DeviceContext deviceContext; // 0x0
	public RequestOptions option; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4618 Offset: 0x2DB0618 VA: 0x2DB4618
	|-TakashoApiCaller.<>c__DisplayClass0_0<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal APIResult<TResponse> <CallApi>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4620 Offset: 0x2DB0620 VA: 0x2DB4620
	|-TakashoApiCaller.<>c__DisplayClass0_0<object, object>.<CallApi>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct TakashoApiCaller.<CallApi>d__0<TRequest, TResponse> : IAsyncStateMachine // TypeDefIndex: 37103
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<TResponse> <>t__builder; // 0x0
	public Func<TRequest, DeviceContext, Nullable<RequestOptions>, APIResult<TResponse>> api; // 0x0
	public TRequest request; // 0x0
	public LtTakashoEndPointCode endPointCode; // 0x0
	public ApiRequestOption requestOption; // 0x0
	public IServerConnectionManager serverConnectionManager; // 0x0
	public CancellationToken cancellationToken; // 0x0
	private TakashoApiCallOperation<TRequest, TResponse> <operation>5__2; // 0x0
	private UniTask.Awaiter <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCAF28 Offset: 0x2DC6F28 VA: 0x2DCAF28
	|-TakashoApiCaller.<CallApi>d__0<object, object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB564 Offset: 0x2DC7564 VA: 0x2DCB564
	|-TakashoApiCaller.<CallApi>d__0<object, object>.SetStateMachine
	*/
}

// Namespace: Lettuce.Takasho.Impl.ApiCaller
public static class TakashoApiCaller // TypeDefIndex: 37104
{
	// Methods

	[AsyncStateMachine(typeof(TakashoApiCaller.<CallApi>d__0<TRequest, TResponse>))]
	// RVA: -1 Offset: -1
	public static UniTask<TResponse> CallApi<TRequest, TResponse>(IServerConnectionManager serverConnectionManager, ApiRequestOption requestOption, CancellationToken cancellationToken, LtTakashoEndPointCode endPointCode, TRequest request, Func<TRequest, DeviceContext, Nullable<RequestOptions>, APIResult<TResponse>> api) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7BDC8 Offset: 0x2D77DC8 VA: 0x2D7BDC8
	|-TakashoApiCaller.CallApi<object, object>
	*/
}

// Namespace: Lettuce.ApiClient.Impl
public class DeleteSaveDataService : IDeleteSaveDataService // TypeDefIndex: 38192
{
	// Fields
	private readonly INPFUserService _npfUserService; // 0x10
	private readonly IAdvertising _advertising; // 0x18
	private readonly ILocalNotificationSchedulerService _localNotificationSchedulerService; // 0x20
	private readonly ITakashoDeviceContextService _takashoDeviceContextService; // 0x28
	private readonly ITakashoPlayerService _takashoPlayerService; // 0x30

	// Methods

	// RVA: 0x312196C Offset: 0x311D96C VA: 0x312196C
	public void .ctor(INPFUserService npfUserService, ITakashoServiceFacade takashoServiceFacade, IAdvertising advertising, ILocalNotificationSchedulerService localNotificationSchedulerService) { }

	[AsyncStateMachine(typeof(DeleteSaveDataService.<Execute>d__6))]
	// RVA: 0x3121E5C Offset: 0x311DE5C VA: 0x3121E5C Slot: 4
	public UniTask Execute() { }
}

