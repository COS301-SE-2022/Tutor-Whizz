import 'dart:typed_data';

import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:tutor_me/src/authenticate/register_step1.dart';
import 'package:tutor_me/src/colorpallete.dart';
import 'package:tutor_me/src/theme/themes.dart';
import '../../services/models/globals.dart';
import '../../services/services/user_services.dart';
import '../tutorProfilePages/settings_pofile_view.dart';
import 'package:tutor_me/src/authenticate/register_or_login.dart';

// ignore: must_be_immutable
class TutorNavigationDrawerWidget extends StatefulWidget {
  Globals globals;

  TutorNavigationDrawerWidget({Key? key, required this.globals})
      : super(key: key);

  @override
  State<StatefulWidget> createState() {
    return TutorNavigationDrawerState();
  }
}

class TutorNavigationDrawerState extends State<TutorNavigationDrawerWidget> {
  final padding = const EdgeInsets.symmetric(horizontal: 20);

  late Uint8List tutorImage;
  bool doesUserImageExist = false;
  bool isImageLoading = true;

  getTutorProfileImage() async {
    try {
      final image =
          await UserServices.getTutorProfileImage(widget.globals.getUser.getId);

      setState(() {
        tutorImage = image;
        doesUserImageExist = true;
        isImageLoading = false;
      });
    } catch (e) {
      setState(() {
        tutorImage = Uint8List(128);
        isImageLoading = false;
      });
    }
  }

  @override
  void initState() {
    super.initState();

    getTutorProfileImage();
  }

  @override
  Widget build(BuildContext context) {
    final provider = Provider.of<ThemeProvider>(context, listen: false);
    Color drawerColor;
    if (provider.themeMode == ThemeMode.dark) {
      drawerColor = colorDarkGrey;
    } else {
      drawerColor = colorOrange;
    }

    return Drawer(
      child: Material(
          color: drawerColor,
          child: ListView(
              // padding: const EdgeInsets.symmetric(horizontal: 20),
              children: <Widget>[
                buildNavHeader(context),
                SizedBox(height: MediaQuery.of(context).size.height * 0.01),
                const Divider(
                  color: colorWhite,
                ),
                buildMenu(
                  text: 'My Account',
                  icon: Icons.account_circle_outlined,
                  onClicked: () {
                    // Navigator.push(
                    //     context,
                    //     MaterialPageRoute(
                    //       builder: (context) =>
                    //           TutorProfileEdit(user: widget.user),
                    //     ));
                  },
                ),
                buildMenu(
                    text: 'Settings',
                    icon: Icons.settings,
                    onClicked: () => selected(context, 1)),
                buildMenu(
                  text: 'Logout',
                  icon: Icons.logout,
                  onClicked: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => const RegisterStep1()),
                    );
                  },
                ),
              ])),
    );
  }

  Widget buildNavHeader(BuildContext context) {
    String name = widget.globals.getUser.getName;
    String fullName = name + ' ' + widget.globals.getUser.getLastName;
    return InkWell(
      onTap: isImageLoading
          ? () {}
          : () async {
              final result = await Navigator.push(
                  context,
                  MaterialPageRoute(
                    builder: (context) => TutorSettingsProfileView(
                        globals: widget.globals,
                        image: tutorImage,
                        imageExists: doesUserImageExist),
                  ));
              Navigator.pop(context);
              setState(() {
                widget.globals.setUser = result.user;
              });

              getTutorProfileImage();
            },
      child: Container(
        padding: padding.add(EdgeInsets.symmetric(
            vertical: MediaQuery.of(context).size.width * 0.05)),
        child: Row(children: <Widget>[
          CircleAvatar(
            backgroundColor: colorTurqoise,
            radius: MediaQuery.of(context).size.height * 0.045,
            child: isImageLoading
                ? const CircularProgressIndicator.adaptive()
                : doesUserImageExist
                    ? ClipOval(
                        child: Image.memory(
                          tutorImage,
                          fit: BoxFit.cover,
                          width: MediaQuery.of(context).size.width * 0.2,
                          height: MediaQuery.of(context).size.width * 0.2,
                        ),
                      )
                    : ClipOval(
                        child: Image.asset(
                        "assets/Pictures/penguin.png",
                        fit: BoxFit.cover,
                        width: MediaQuery.of(context).size.width * 0.253,
                        height: MediaQuery.of(context).size.width * 0.253,
                      )),
          ),
          SizedBox(
            width: MediaQuery.of(context).size.height * 0.022,
          ),
          Expanded(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                Text(
                  fullName,
                  style: TextStyle(
                      fontSize: MediaQuery.of(context).size.height * 0.04,
                      color: colorWhite),
                  overflow: TextOverflow.fade,
                ),
                SizedBox(height: MediaQuery.of(context).size.width * 0.01),
                Text(
                  widget.globals.getUser.getEmail,
                  style: TextStyle(
                      fontSize: MediaQuery.of(context).size.height * 0.02,
                      color: colorWhite),
                  overflow: TextOverflow.ellipsis,
                )
              ],
            ),
          )
        ]),
      ),
    );
  }

  Widget buildMenu({
    required String text,
    required IconData icon,
    VoidCallback? onClicked,
  }) {
    return ListTile(
      contentPadding: padding,
      leading: Icon(
        icon,
        color: const Color(0xffFFFFFF),
      ),
      title: Text(text, style: const TextStyle(color: Color(0xffFFFFFF))),
      onTap: onClicked,
    );
  }

  void selected(BuildContext context, int index) {
    Navigator.pop(context);
    if (index == 0) {}
    // else if(index == 1) {
    //   Navigator.of(context).push(MaterialPageRoute(builder: builder))
    // }
  }
}
