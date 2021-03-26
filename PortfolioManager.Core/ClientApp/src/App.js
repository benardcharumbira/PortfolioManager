import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./Layout/Layout";
import { Home } from "./Components/Home/Home";
import Company from "./Components/Company/Company";
import Dashboard from "./Components/Dashboard/Dashboard";

import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/" component={Home} />
        <Route path="/companies" component={Company} />
        <Route path="/sectors" component={Dashboard} />
      </Layout>
    );
  }
}
