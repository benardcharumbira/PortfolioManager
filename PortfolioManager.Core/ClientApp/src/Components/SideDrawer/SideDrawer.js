import React from "react";
import Drawer from "@material-ui/core/Drawer";
import CssBaseline from "@material-ui/core/CssBaseline";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import List from "@material-ui/core/List";
import Typography from "@material-ui/core/Typography";
import Divider from "@material-ui/core/Divider";
import ListItem from "@material-ui/core/ListItem";
import ListItemIcon from "@material-ui/core/ListItemIcon";
import ListItemText from "@material-ui/core/ListItemText";
import HomeIcon from "@material-ui/icons/Home";
import EqualizerIcon from "@material-ui/icons/Equalizer";
import Company from "../Company/Company";
import { Link } from "react-router-dom";
import { useStyles } from "./SideBarStyles";

export default function SideDrawer() {
  const classes = useStyles();

  return (
    <div className={classes.root}>
      <CssBaseline />
      <AppBar position="fixed" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            Portfolio Manager
          </Typography>
        </Toolbar>
      </AppBar>
      <Drawer
        className={classes.drawer}
        variant="permanent"
        classes={{
          paper: classes.drawerPaper,
        }}
        anchor="left"
      >
        <div className={classes.toolbar} />
        <Divider />
        <List>
          <Link to="/">
            <ListItem button key={1}>
              <ListItemIcon>{<HomeIcon />}</ListItemIcon>
              <ListItemText primary={"Home"} />
            </ListItem>
          </Link>
          <Link to="companies">
            <ListItem button key={2}>
              <ListItemIcon>{<EqualizerIcon />}</ListItemIcon>
              <ListItemText primary={"Companies"} />
            </ListItem>
          </Link>
        </List>
      </Drawer>
    </div>
  );
}
