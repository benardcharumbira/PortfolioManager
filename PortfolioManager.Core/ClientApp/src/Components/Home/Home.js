import React, { Component } from "react";
import { Link } from "react-router-dom";
import Button from "@material-ui/core/Button";
import SideDrawer from "../SideDrawer/SideDrawer";
import CandlestickChart from "../Charts/CandlestickChart/CandlestickChart";
import { getData } from "../Charts/utils";

import { TypeChooser } from "react-stockcharts/lib/helper";

export class Home extends Component {
  componentDidMount() {
    getData().then((data) => {
      this.setState({ data });
    });
  }
  render() {
    if (this.state == null) {
      return <div>Loading...</div>;
    }

    return <CandlestickChart data={this.state.data} />;
  }
}

// To be used
// <TypeChooser>
//   {(type) => <CandlestickChart type={type} data={this.state.data} />}
// </TypeChooser>
{
  /* <div> */
}
{
  /* <SideDrawer /> */
}

{
  /* <div className="text-center">
  <h1 className="mt-5">Hello!</h1>
  <p>Welcome to Portofolio Manager</p>
  <Link to="companies">
    <Button variant="contained" size="large" color="primary">
      BROWSE AVAILABLE DATA
    </Button>
  </Link>
</div>
</div> */
}
