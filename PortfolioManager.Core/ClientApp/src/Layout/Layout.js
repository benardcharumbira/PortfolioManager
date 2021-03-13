import React, { Component } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "../Components/NavMenu/NavMenu";
import SideDrawer from "../Components/SideDrawer/SideDrawer";

export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <NavMenu />
        {/* Temporarily disabled*/}
        {/* <SideDrawer/> */}
        <Container>{this.props.children}</Container>
      </div>
    );
  }
}
