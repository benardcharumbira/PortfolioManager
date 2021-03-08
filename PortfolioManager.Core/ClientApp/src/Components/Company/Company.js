import React, { useState, useEffect } from "react";
import { getCompanies } from "../../Services/Api/gets";
import DataTable from "../DataTable/DataTable";

const Company = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    load();
  }, []);

  const load = async () => {
    var data = await getCompanies();
    setData(data);
  };

  return (
    <div>
      {data.length ? (
        <div>
          <h1 className="text-center mt-3 mb-3">Indian Stock Market</h1>
          <DataTable data={data} />
        </div>
      ) : (
        <h1 className="text-center">Loading data...</h1>
      )}
    </div>
  );
};

export default Company;
