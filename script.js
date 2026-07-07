// AI Meeting Assistant (Enterprise Edition) - Core Script

// 1. Sidebar Toggle Logic
document.getElementById("menu-toggle").addEventListener("click", function(e) {
    e.preventDefault();
    document.getElementById("wrapper").classList.toggle("toggled");
});

// 2. Bilingual Dictionary (English / Hindi)
const translations = {
    en: {
        app_title: "AI Assistant",
        nav_dashboard: "Dashboard",
        nav_recorder: "Meeting Recorder",
        nav_mom: "Auto MoM",
        nav_tasks: "Task Generator",
        nav_raci: "RACI Matrix",
        nav_risk: "Risk Detection",
        role_superadmin: "Super Admin",
        dashboard_title: "Executive Dashboard",
        btn_new_meeting: "New AI Meeting",
        stat_total_meetings: "Total Meetings",
        stat_up: "12% this month",
        stat_pending_decisions: "Pending Decisions",
        stat_attention: "Requires attention",
        stat_delayed_tasks: "Delayed Tasks",
        stat_critical: "5 Critical",
        stat_performance: "Performance Score",
        stat_excellent: "Excellent",
        section_recent_tasks: "Recent AI Generated Tasks",
        btn_view_all: "View All",
        th_task: "Task",
        th_assigned: "Assigned To",
        th_priority: "Priority",
        th_status: "Status",
        th_progress: "Progress",
        section_risk: "AI Risk Detection",
        section_recommend: "AI Recommendation",
        section_raci: "AI Responsibility Matrix (RACI)",
        th_work: "Work",
        th_responsible: "Responsible (R)",
        th_accountable: "Accountable (A)",
        th_consulted: "Consulted (C)",
        th_informed: "Informed (I)"
    },
    hi: {
        app_title: "एआई सहायक",
        nav_dashboard: "डैशबोर्ड",
        nav_recorder: "मीटिंग रिकॉर्डर",
        nav_mom: "ऑटो एमओएम",
        nav_tasks: "टास्क जनरेटर",
        nav_raci: "रेसी (RACI) मैट्रिक्स",
        nav_risk: "जोखिम का पता लगाना",
        role_superadmin: "सुपर एडमिन",
        dashboard_title: "कार्यकारी डैशबोर्ड",
        btn_new_meeting: "नई एआई मीटिंग",
        stat_total_meetings: "कुल बैठकें",
        stat_up: "इस महीने 12%",
        stat_pending_decisions: "लंबित निर्णय",
        stat_attention: "ध्यान देने की आवश्यकता है",
        stat_delayed_tasks: "विलंबित कार्य",
        stat_critical: "5 अति महत्वपूर्ण",
        stat_performance: "प्रदर्शन स्कोर",
        stat_excellent: "उत्कृष्ट",
        section_recent_tasks: "हाल ही में एआई जनित कार्य",
        btn_view_all: "सभी देखें",
        th_task: "कार्य (Task)",
        th_assigned: "सौंपा गया",
        th_priority: "प्राथमिकता",
        th_status: "स्थिति",
        th_progress: "प्रगति",
        section_risk: "एआई जोखिम का पता लगाना",
        section_recommend: "एआई सिफ़ारिश",
        section_raci: "एआई उत्तरदायित्व मैट्रिक्स (RACI)",
        th_work: "कार्य",
        th_responsible: "जिम्मेदार (R)",
        th_accountable: "जवाबदेह (A)",
        th_consulted: "परामर्शित (C)",
        th_informed: "सूचित (I)"
    }
};

// 3. Language Toggle Logic
const langToggle = document.getElementById("lang-toggle");

function setLanguage(lang) {
    document.querySelectorAll("[data-i18n]").forEach(element => {
        const key = element.getAttribute("data-i18n");
        if (translations[lang] && translations[lang][key]) {
            element.textContent = translations[lang][key];
        }
    });
}

langToggle.addEventListener("change", function() {
    if(this.checked) {
        // Toggle is ON -> Hindi
        setLanguage('hi');
    } else {
        // Toggle is OFF -> English
        setLanguage('en');
    }
});

// Initialize with English
setLanguage('en');
