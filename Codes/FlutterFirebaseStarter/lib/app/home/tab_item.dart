import 'package:flutter/material.dart';
import 'package:starter_architecture_flutter_firebase/constants/keys.dart';
import 'package:starter_architecture_flutter_firebase/constants/strings.dart';

enum TabItem { jobs, entries, account, notification }

class TabItemData {
  const TabItemData(
      {required this.key, required this.title, required this.icon});

  final String key;
  final String title;
  final IconData icon;

  static const Map<TabItem, TabItemData> allTabs = {
    TabItem.jobs: TabItemData(
      key: Keys.jobsTab,
      title: Strings.jobs,
      icon: Icons.work,
    ),
    TabItem.entries: TabItemData(
      key: Keys.entriesTab,
      title: Strings.entries,
      icon: Icons.view_headline,
    ),
    TabItem.account: TabItemData(
      key: Keys.accountTab,
      title: Strings.account,
      icon: Icons.person,
    ),
    TabItem.notification: TabItemData(
      key: Keys.notificationTab,
      title: Strings.notification,
      icon: Icons.notifications,
    )
  };
}
