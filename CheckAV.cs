using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckAV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHECK AV PROCESS......");
            av();
        }


        public static void av()
        {

            Dictionary<string, string> av_list = new Dictionary<string, string>();
            av_list.Add("360tray", "360安全卫士-实时保护");
            av_list.Add("360safe", "360安全卫士-主程序");
            av_list.Add("ZhuDongFangYu", "360安全卫士-主动防御");
            av_list.Add("360sd", "360杀毒");
            av_list.Add("360rp", "360杀毒");
            av_list.Add("360skylarsvc", "360天擎终端安全管理系统");
            av_list.Add("LiveUpdate360", "360杀毒");
            av_list.Add("a2guard", "a-squared杀毒");
            av_list.Add("ad-watch", "Lavasoft杀毒");
            av_list.Add("cleaner8", "The Cleaner杀毒");
            av_list.Add("vba32lder", "vb32杀毒");
            av_list.Add("MongoosaGUI", "Mongoosa杀毒");
            av_list.Add("CorantiControlCenter32", "Coranti2012杀毒");
            av_list.Add("F-PROT", "F-Prot AntiVirus");
            av_list.Add("CMCTrayIcon", "CMC杀毒");
            av_list.Add("K7TSecurity", "K7杀毒");
            av_list.Add("UnThreat", "UnThreat杀毒");
            av_list.Add("CKSoftShiedAntivirus4", "Shield Antivirus杀毒");
            av_list.Add("AVWatchService", "VIRUSfighter杀毒");
            av_list.Add("ArcaTasksService", "ArcaVir杀毒");
            av_list.Add("iptray", "Immunet杀毒");
            av_list.Add("PSafeSysTray", "PSafe杀毒");
            av_list.Add("nspupsvc", "nProtect杀毒");
            av_list.Add("SpywareTerminatorShield", "SpywareTerminator杀毒");
            av_list.Add("BKavService", "Bkav杀毒");
            av_list.Add("MsMpEng", "Microsoft Security Essentials");
            av_list.Add("SBAMSvc", "VIPRE");
            av_list.Add("ccSvcHst", "Norton杀毒");
            av_list.Add("f-secure", "冰岛");
            av_list.Add("avp", "Kaspersky");
            av_list.Add("kavfs", "Kaspersky");
            av_list.Add("klnagent", "Kaspersky");
            av_list.Add("kavtray", "Kaspersky");
            av_list.Add("kavfswp", "Kaspersky");
            av_list.Add("KvMonXP", "江民杀毒");
            av_list.Add("RavMonD", "瑞星杀毒");
            av_list.Add("Mcshield", "Mcafee");
            av_list.Add("Tbmon", "Mcafee");
            av_list.Add("Frameworkservice", "Mcafee");
            av_list.Add("shstat", "Mcafee");
            av_list.Add("McTray", "Mcafee");
            av_list.Add("mfeann", "Mcafee");
            av_list.Add("mfevtps", "Mcafee");
            av_list.Add("UdaterUI", "Mcafee");
            av_list.Add("naPrdMgr", "Mcafee");
            av_list.Add("VsTskMgr", "Mcafee");
            av_list.Add("EngineServer", "Mcafee");
            av_list.Add("FrameworkService", "Mcafee");
            av_list.Add("egui", "ESET NOD32");
            av_list.Add("ekrn", "ESET NOD32");
            av_list.Add("EShaSrv", "ESET NOD32");
            av_list.Add("eguiProxy", "ESET NOD32");
            av_list.Add("kxetray", "金山毒霸");
            av_list.Add("knsdtray", "可牛杀毒");
            av_list.Add("TMBMSRV", "趋势杀毒");
            av_list.Add("ntrtscan", "趋势杀毒");
            av_list.Add("avcenter", "Avira(小红伞)");
            av_list.Add("avguard", "Avira(小红伞)");
            av_list.Add("avgnt", "Avira(小红伞)");
            av_list.Add("sched", "Avira(小红伞)");
            av_list.Add("ashDisp", "Avast网络安全");
            av_list.Add("rtvscan", "诺顿杀毒");
            av_list.Add("ccapp", "Symantec Norton");
            av_list.Add("NPFMntor", "Norton杀毒软件相关进程");
            av_list.Add("ccSetMgr", "赛门铁克");
            av_list.Add("ccEvtMgr", "赛门铁克");
            av_list.Add("ccsvchst", "赛门铁克");
            av_list.Add("smc", "赛门铁克");
            av_list.Add("smcGui", "赛门铁克");
            av_list.Add("snac", "赛门铁克");
            av_list.Add("ccRegVfy", "Norton杀毒软件自身完整性检查程序");
            av_list.Add("vptray", "Norton病毒防火墙-盾牌图标程序");
            av_list.Add("ksafe", "金山卫士");
            av_list.Add("QQPCRTP", "QQ电脑管家");
            av_list.Add("QQPCTray", "QQ电脑管家");
            av_list.Add("QQPCNetFlow", "QQ电脑管家");
            av_list.Add("QQPCRealTimeSpeedup", "QQ电脑管家");
            av_list.Add("Miner", "流量矿石");
            av_list.Add("AYAgent", "韩国胶囊");
            av_list.Add("patray", "安博士");
            av_list.Add("V3Svc", "安博士V3");
            av_list.Add("avgwdsvc", "AVG杀毒");
            av_list.Add("QUHLPSVC", "QUICK HEAL杀毒");
            av_list.Add("mssecess", "微软杀毒");
            av_list.Add("SavProgress", "Sophos杀毒");
            av_list.Add("SavMain", "Sophos杀毒");
            av_list.Add("fsavgui", "F-Secure杀毒");
            av_list.Add("vsserv", "比特梵德");
            av_list.Add("remupd", "熊猫卫士");
            av_list.Add("FortiTray", "飞塔");
            av_list.Add("safedog", "安全狗");
            av_list.Add("parmor", "木马克星");
            av_list.Add("Iparmor", "木马克星");
            av_list.Add("beikesan", "贝壳云安全");
            av_list.Add("KSWebShield", "金山网盾");
            av_list.Add("TrojanHunter", "木马猎手");
            av_list.Add("GG", "巨盾网游安全盾");
            av_list.Add("adam", "绿鹰安全精灵");
            av_list.Add("AST", "超级巡警");
            av_list.Add("ananwidget", "墨者安全专家");
            av_list.Add("AVK", "GData");
            av_list.Add("GDScan", "GData");
            av_list.Add("AVKWCtl", "GData");
            av_list.Add("AVKCl", "GData");
            av_list.Add("AVKProxy", "GData");
            av_list.Add("AVKBackupService", "GData");
            av_list.Add("avg", "AVG Anti-Virus");
            av_list.Add("spidernt", "Dr.web");
            av_list.Add("avgaurd", "Avira Antivir");
            av_list.Add("vsmon", "ZoneAlarm");
            av_list.Add("cpf", "Comodo");
            av_list.Add("outpost", "Outpost Firewall");
            av_list.Add("rfwmain", "瑞星防火墙");
            av_list.Add("kpfwtray", "金山网镖");
            av_list.Add("FYFireWall", "风云防火墙");
            av_list.Add("MPMon", "微点主动防御");
            av_list.Add("pfw", "天网防火墙");
            av_list.Add("1433", "在扫1433");
            av_list.Add("DUB", "在爆破");
            av_list.Add("ServUDaemon", "发现S-U");
            av_list.Add("BaiduSdSvc", "百度杀毒-服务进程");
            av_list.Add("BaiduSdTray", "百度杀毒-托盘进程");
            av_list.Add("BaiduSd", "百度杀毒-主程序");
            av_list.Add("SafeDogGuardCenter", "安全狗");
            av_list.Add("safedogupdatecenter", "安全狗");
            av_list.Add("safedogguardcenter", "安全狗");
            av_list.Add("SafeDogSiteIIS", "安全狗");
            av_list.Add("SafeDogTray", "安全狗");
            av_list.Add("SafeDogServerUI", "安全狗");
            av_list.Add("D_Safe_Manage", "D盾");
            av_list.Add("d_manage", "D盾");
            av_list.Add("yunsuo_agent_service", "云锁");
            av_list.Add("yunsuo_agent_daemon", "云锁");
            av_list.Add("HwsPanel", "护卫神");
            av_list.Add("hws_ui", "护卫神");
            av_list.Add("hws", "护卫神");
            av_list.Add("hwsd", "护卫神");
            av_list.Add("hipstray", "火绒");
            av_list.Add("wsctrl", "火绒");
            av_list.Add("usysdiag", "火绒");
            av_list.Add("HipsDaemon", "火绒");
            av_list.Add("HipsLog", "火绒");
            av_list.Add("HipsMain", "火绒");
            av_list.Add("WEBSCANX", "网络病毒克星");
            av_list.Add("SPHINX", "SPHINX防火墙");
            av_list.Add("bddownloader", "百度卫士");
            av_list.Add("baiduansvx", "百度卫士-主进程");
            av_list.Add("AvastUI", "Avast!5主程序");
            av_list.Add("ClamTray", "ClemWin Free Antivirus");
            av_list.Add("clamscan", "ClemWin Free Antivirus");
            av_list.Add("MBAMService", "ClemWin Free Antivirus");
            av_list.Add("mbam", "ClemWin Free Antivirus");
            av_list.Add("mbamtray", "Malwarebytes");

            av_list.Add("NisSrv", "windows defender");
            av_list.Add("MsSense", "windows defender");
            av_list.Add("MpCmdRun", "windows defender");
            av_list.Add("MSASCui", "windows defender");
            av_list.Add("MSASCuiL", "windows defender");
            av_list.Add("SecurityHealthService", "windows defender");

            Console.WriteLine("查看当前环境存在的杀毒软件......");
            Console.WriteLine("获取到的杀软进程如下......\r\n");
            foreach (KeyValuePair<string, string> kvp in av_list)
            {
                Process[] proce = Process.GetProcessesByName(kvp.Key);
                if (proce.Length!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(kvp.Key + "：" + kvp.Value);
                }
            }
        }
    }
}