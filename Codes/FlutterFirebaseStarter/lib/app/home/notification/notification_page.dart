import 'package:firebase_messaging/firebase_messaging.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:starter_architecture_flutter_firebase/constants/strings.dart';

class NotificationPage extends StatefulWidget {

  @override
  _NotificationPageState createState() => _NotificationPageState();

}

class _NotificationPageState extends State<NotificationPage> {
  String messageTitle = 'Empty';
  String notificationAlert = 'alert';

  @override
  void initState() {
    FirebaseMessaging.onMessage.listen((RemoteMessage message) async {
      setState(() {
        messageTitle = message.notification!.title!.toString();
        notificationAlert = 'New Notification Alert';
      });
    });

    FirebaseMessaging.onMessageOpenedApp.listen((RemoteMessage message) async {
      setState(() {
        messageTitle = message.data['title'].toString();
        notificationAlert = 'Application opened from Notification';
      });
    });

    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(Strings.notification),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Text(
              notificationAlert,
            ),
            Text(
              messageTitle,
              style: Theme.of(context).textTheme.headline4,
            ),
          ],
        ),
      ),
    );
  }
}