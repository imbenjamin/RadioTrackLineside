using System;
using System.Runtime.InteropServices;
//
// This provides a C# wrapper class on top of the pcProxAPI.dll
// to that the functions may be called from C#
//
namespace RFIDeas_pcProxAPI
{
    //
    // Low level legacy Interface to pcProxAPI.DLL
    //
    static class pcProxDLLAPI
    {
        // Used by SetConnectProduct()
        public const uint PRODUCT_ALL =    0x0FFFFFFFF;
        public const uint PRODUCT_PCPROX = 0x000000001;
        public const uint PRODUCT_PCSWIPE =0x000000002;
        public const uint PRODUCT_PCSONAR =0x000000004;
        // Used by SetDevTypeSrch()
        public const short PRXDEVTYP_ALL = -1; // All types of interfaces USB, Serial, etc...
        public const short PRXDEVTYP_USB = 0;  // USB only
        public const short PRXDEVTYP_SER = 1;  // Serial (Virtual COM & RS-232) Only
        public const short PRXDEVTYP_TCP = 2;  // TCP/IP
        //
        [DllImport("pcProxAPI.dll")] public static extern  ushort BeepNow(byte count, ushort Int32Beep);
        [DllImport("pcProxAPI.dll")] public static extern  ushort ComDisconnect();
        [DllImport("pcProxAPI.dll")] public static extern   short FindXport(short ip0, short ip1, short ip2, short ip3begin, short ip3end);
        [DllImport("pcProxAPI.dll")] public static extern  ushort GetAZERTYShiftLock();
        [DllImport("pcProxAPI.dll")] public static extern   short GetActConfig();
        [DllImport("pcProxAPI.dll")] public static extern   short GetActDev();
        [DllImport("pcProxAPI.dll")] public static extern   Int32 GetCardPriority();
        [DllImport("pcProxAPI.dll")] public static extern   Int32 GetCardType();
        [DllImport("pcProxAPI.dll")] public static extern   short GetDID();
        [DllImport("pcProxAPI.dll")] public static extern   short GetDevByLUID(short LUID, short index);
        [DllImport("pcProxAPI.dll")] public static extern   short GetDevCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short GetDevType();
        [DllImport("pcProxAPI.dll")] public static extern  ushort GetExtendedPrecisionMath();
        [DllImport("pcProxAPI.dll")] public static extern    uint GetFirmwareVersion(short hardware, short module1);
        [DllImport("pcProxAPI.dll")] public static extern   short GetLUID();
        [DllImport("pcProxAPI.dll")] public static extern   Int32 GetLastLibErr();
        [DllImport("pcProxAPI.dll")] public static extern  ushort GetMaxConfig();
        [DllImport("pcProxAPI.dll")] public static extern  UInt32 GetMyIpAddress();
        [DllImport("pcProxAPI.dll")] public static extern  UInt32 GetProduct();
        [DllImport("pcProxAPI.dll")] public static extern   short GetQueuedID(short clearUID, short clearHold);
        [DllImport("pcProxAPI.dll")] public static extern   Int32 GetQueuedID_index(short index);
        [DllImport("pcProxAPI.dll")] public static extern    uint GetSN();
        [DllImport("pcProxAPI.dll")] public static extern  ushort GetUnsupportedProductErrorCode();
        [DllImport("pcProxAPI.dll")] public static extern Boolean HaltKBSends(Boolean bHalt);
        [DllImport("pcProxAPI.dll")] public static extern  ushort IsCardTypeInList(ushort findCT);
        [DllImport("pcProxAPI.dll")] public static extern   Int32 Ping ();
        [DllImport("pcProxAPI.dll")] public static extern  ushort ReadCfg();
        [DllImport("pcProxAPI.dll")] public static extern  ushort ResetFactoryDflts();
        [DllImport("pcProxAPI.dll")] public static extern Boolean ResetUserDflts();
        [DllImport("pcProxAPI.dll")] public static extern Boolean SaveUserDflts();
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetAZERTYShiftLock(short on1);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetActConfig(byte n);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetActDev(short iNdx);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetCardTypePriority(ushort cardType, ushort priority);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetComSrchRange(ushort iMin, ushort iMax);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetConnectProduct(UInt32 bits);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetDevTypeSrch(short iSrchType);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetExtendedPrecisionMath(short on1);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetIpPort(byte i0, byte i1, byte i2, byte i3, ushort port);
        [DllImport("pcProxAPI.dll")] public static extern  ushort SetLUID(short LUID);
        [DllImport("pcProxAPI.dll")] public static extern    void SetUnsupportedProductErrorCode(ushort v);
        [DllImport("pcProxAPI.dll")] public static extern  ushort USBDisconnect();
        [DllImport("pcProxAPI.dll")] public static extern  ushort VirtualComSearchRange(ushort iMin, ushort iMax);
        [DllImport("pcProxAPI.dll")] public static extern  ushort WriteCfg();
        [DllImport("pcProxAPI.dll")] public static extern   short chkAddArrival_char(short index, char c);
        [DllImport("pcProxAPI.dll")] public static extern   short chkDelRemoval_char(short index, char c);
        [DllImport("pcProxAPI.dll")] public static extern  ushort comConnect();
        [DllImport("pcProxAPI.dll")] public static extern  ushort comConnectPort(ushort iPort);
        [DllImport("pcProxAPI.dll")] public static extern  ushort getActiveCardData();
        [DllImport("pcProxAPI.dll")] public static extern  ushort getActiveCardData_byte(short index);
        [DllImport("pcProxAPI.dll")] public static extern   short getActiveID(short wBufMaxSz);
        [DllImport("pcProxAPI.dll")] public static extern   short getActiveID32(short wBufMaxSz);
        [DllImport("pcProxAPI.dll")] public static extern    byte getActiveID_byte(short index);
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_bVolatile();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iBeeperState();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iPad0();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iPad3();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iPad4();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iPad5();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getBprRlyCtrl_iRelayState();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bBeepID();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bDspHex();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bRevBytes();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bRevWiegBits();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bUseInvDataF();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bUseLeadChrs();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_bWiegInvData();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags2_iPad7();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bLowerCaseHex();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bNotBootDev();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bPrxProEm();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bSndSFFC();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bSndSFID();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bSndSFON();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bUse64Bit();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags3_bUseNumKP();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bFixLenDsp();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bFrcBitCntEx();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bHaltKBSnd();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bNoUseELChar();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bSndFac();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bSndOnRx();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bStripFac();
        [DllImport("pcProxAPI.dll")] public static extern   short getCfgFlags_bUseDelFac2Id();
        [DllImport("pcProxAPI.dll")] public static extern    char getDevName_char(short index);
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iIDBitCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iLeadParityBitCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iPad4();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iPad5();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iPad7();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iTotalBitCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDBitCnts_iTrailParityBitCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iCrdGnChr0();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iCrdGnChr1();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iLeadChr0();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iLeadChr1();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iLeadChr2();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iLeadChrCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms2_iPad7();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iPad4();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iPad5();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iPad7();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iTrailChr0();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iTrailChr1();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iTrailChr2();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms3_iTrailChrCnt();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iELDelim();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iFACDispLen();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iFACIDDelim();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iIDDispLen();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iPad4();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iPad5();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getIDDispParms_iPad7();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_bAppCtrlsLED();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_bVolatile();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iGrnLEDState();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iPad3();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iPad4();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iPad5();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getLEDCtrl_iRedLEDState();
        [DllImport("pcProxAPI.dll")] public static extern   short getLibraryVersion_Build();
        [DllImport("pcProxAPI.dll")] public static extern   short getLibraryVersion_Major();
        [DllImport("pcProxAPI.dll")] public static extern   short getLibraryVersion_Minor();
        [DllImport("pcProxAPI.dll")] public static extern    char getPartNumberString_char(short index);
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_ExFeatures01();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iBitStrmTO();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iIDHoldTO();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iIDLockOutTm();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iPad6();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iTPCfgFlg3();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iUSBKeyPrsTm();
        [DllImport("pcProxAPI.dll")] public static extern   short getTimeParms_iUSBKeyRlsTm();
        [DllImport("pcProxAPI.dll")] public static extern    char getVidPidVendorName_char(short index);
        [DllImport("pcProxAPI.dll")] public static extern Boolean pcProxPlusDefaults();
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeClearDataAvailable();
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeClearOverrun();
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetBeeper(ushort i);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldEnable(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldIgnoreLRC(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldKeyCount(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldKeydata(ushort field, ushort kindex);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldLength(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldMagField(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldOffset(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldShowLRC(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldShowSepSen(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldSkip(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldTerm(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetFieldTrack(ushort field);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetLED(ushort i);
        [DllImport("pcProxAPI.dll")] public static extern    uint pcSwipeGetSystemCardsRead();
        [DllImport("pcProxAPI.dll")] public static extern   Int32 pcSwipeGetSystemInternalCount(Int32 index);
        [DllImport("pcProxAPI.dll")] public static extern    uint pcSwipeGetSystemUptime();
        [DllImport("pcProxAPI.dll")] public static extern    byte pcSwipeGetTrackData_BYTE(ushort track, ushort toAscii, ushort index);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeGetTrackEnables();
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeIsDataAvailable();
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetActiveID(ushort track, ushort magField, ushort offset, ushort term);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetBeeper(ushort i, ushort count, ushort Int32Beep);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldEnable(ushort field, ushort enable);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldIgnoreLRC(ushort field, ushort enable);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldKeyCount(ushort field, byte nKeys);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldKeydata(ushort field, ushort kindex, ushort value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldLength(ushort field, ushort length);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldMagField(ushort field, ushort fieldNo);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldOffset(ushort field, ushort byteOfs);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldShowLRC(ushort field, ushort enable);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldShowSepSen(ushort field, ushort enable);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldSkip(ushort field, ushort enable);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldTerm(ushort field, ushort term);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetFieldTrack(ushort field, ushort trackNo);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetLED(ushort i, ushort v);
        [DllImport("pcProxAPI.dll")] public static extern  ushort pcSwipeSetTrackEnables(ushort trackEnables);
        [DllImport("pcProxAPI.dll")] public static extern    uint quickReadSerialPort_char(short index);
        [DllImport("pcProxAPI.dll")] public static extern  ushort readDevCfgFmFile_char(short index, char c);
        [DllImport("pcProxAPI.dll")] public static extern    uint readSerialPort_char(short index);
        [DllImport("pcProxAPI.dll")] public static extern   short rf_GetDevType();
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_bVolatile(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iBeeperState(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iPad0(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iPad3(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iPad4(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iPad5(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setBprRlyCtrl_iRelayState(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bBeepID(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bDspHex(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bRevBytes(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bRevWiegBits(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bUseInvDataF(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bUseLeadChrs(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_bWiegInvData(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags2_iPad7(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bLowerCaseHex(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bNotBootDev(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bPrxProEm(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bSndSFFC(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bSndSFID(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bSndSFON(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bUse64Bit(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags3_bUseNumKP(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bFixLenDsp(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bFrcBitCntEx(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bHaltKBSnd(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bNoUseELChar(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bSndFac(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bSndOnRx(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bStripFac(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setCfgFlags_bUseDelFac2Id(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iIDBitCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iLeadParityBitCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iPad4(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iPad5(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iPad7(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iTotalBitCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDBitCnts_iTrailParityBitCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iCrdGnChr0(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iCrdGnChr1(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iLeadChr0(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iLeadChr1(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iLeadChr2(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iLeadChrCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms2_iPad7(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iPad4(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iPad5(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iPad7(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iTrailChr0(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iTrailChr1(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iTrailChr2(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms3_iTrailChrCnt(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iELDelim(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iFACDispLen(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iFACIDDelim(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iIDDispLen(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iPad4(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iPad5(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setIDDispParms_iPad7(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_bAppCtrlsLED(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_bVolatile(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iGrnLEDState(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iPad3(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iPad4(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iPad5(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setLEDCtrl_iRedLEDState(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_ExFeatures01(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iBitStrmTO(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iIDHoldTO(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iIDLockOutTm(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iPad6(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iTPCfgFlg3(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iUSBKeyPrsTm(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort setTimeParms_iUSBKeyRlsTm(short value);
        [DllImport("pcProxAPI.dll")] public static extern  ushort usbConnect();
        [DllImport("pcProxAPI.dll")] public static extern  ushort writeDevCfgToFile_char(short index, char c);

        // C# string wrapper functions below
        // ---------------------------------

        //
        // Return the device name such as
        // "\?\hid#vid_0c27&pid_3bfa#7&1234f416&0&0000#" -
        // "{884c96c3-16df-12d2-a485-0010d61708a1}"
        //
        public static string getDeviceName()
        {
            string s = "";
            for(short i = 0; i<127; i++)
            {
                char c = getDevName_char(i);
                if(c == 0)
                {
                    break;
                }
                s = s + c;
            }
            return s;
        }
        //
        // Return the part number stirng such as
        // " RDR-7L81AK0"
        //
        public static string getPartNumberString()
        {
            string s = "";
            for(short i = 0; i<127; i++)
            {
                char c = getPartNumberString_char(i);
                if(c == 0)
                {
                    break;
                }
                s = s + c;
            }
            return s;
        }
        //
        // Wead device configuration from file as
        // string myFile = "MyConfig.hwg+";
        // readDevCfgFmFile(myFile);
        //
        public static ushort readDevCfgFmFile(string fileName)
        {
            for(short i = 0; i<fileName.Length; i++)
            {
                readDevCfgFmFile_char(i, fileName[i]);
            }
            return readDevCfgFmFile_char(255,(char)0);
        }
        //
        // Write device configuration to file as
        // string myFile = "MyConfig.hwg+";
        // writeDevCfgToFile(myFile);
        //
        public static ushort writeDevCfgToFile(string fileName)
        {
            for(short i = 0; i<fileName.Length; i++)
            {
                writeDevCfgToFile_char(i, fileName[i]);
            }
            return writeDevCfgToFile_char(255,(char)0);
        }
        //
        // check if device name has been added to usb bus.
        // string name getDeviceName();
        // short x = chkAddArrival(name);
        //
        public static short chkAddArrival(string deviceName)
        {
            for(short i = 0; i<deviceName.Length; i++)
            {
                writeDevCfgToFile_char(i, deviceName[i]);
            }
            return chkAddArrival_char(255,(char)0);
        }
        //
        // check if device name has been removed from usb bus.
        // string name getDeviceName();
        // short x = chkDelRemoval(name);
        //
        public static short chkDelRemoval(string deviceName)
        {
            for(short i = 0; i<deviceName.Length; i++)
            {
                chkDelRemoval_char(i, deviceName[i]);
            }
            return chkDelRemoval_char(255,(char)0);
        }
    }
}



