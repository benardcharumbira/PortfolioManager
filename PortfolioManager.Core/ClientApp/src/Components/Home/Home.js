import React, { Component } from "react";
import { Link } from "react-router-dom";
import Button from "@material-ui/core/Button";
import SideDrawer from "../SideDrawer/SideDrawer";

export class Home extends Component {
  render() {
    return (
      <div>
        {/* <SideDrawer /> */}

        <div className="text-center">
          <h1 className="mt-5">Hello!</h1>
          <p>Welcome to Portofolio Manager</p>
          <Link to="companies">
            <Button variant="contained" size="large" color="primary">
              BROWSE AVAILABLE DATA
            </Button>
          </Link>
        </div>
      </div>
    );
  }
}
