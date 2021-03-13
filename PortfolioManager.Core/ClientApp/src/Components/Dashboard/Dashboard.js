import React, { useEffect, useState } from "react";
import { Doughnut } from "react-chartjs-2";
import { getCompanySectors } from "../../Services/Api/gets";

const Dashboard = () => {
  const [data, setData] = useState([]);
  const [labels, setLabels] = useState([]);
  const [colorData, setColorData] = useState([]);
  let colors = [];

  const doughnutData = {
    labels,
    datasets: [
      {
        label: "My First dataset",
        backgroundColor: colorData,
        borderWidth: 1,
        data,
      },
    ],
  };

  const generateRandomColor = () => {
    var randomColor = "#" + Math.floor(Math.random() * 16777215).toString(16);
    return `${randomColor}`;
  };

  const loadData = async () => {
    var data = await getCompanySectors();
    if (data != null) {
      setData(data.companyTotalsPerSector);
      setLabels(data.sectorNames);

      //Generate random colors for each sector
      for (let i = 0; i < data.companyTotalsPerSector.length; i++) {
        colors.push(generateRandomColor());
      }
      if (colors.length) {
        setColorData(colors);
      }
    }
  };

  useEffect(() => {
    loadData();
  }, []);

  return (
    <div>
      {doughnutData == null ? (
        <h1 className="text-center">Loading data...</h1>
      ) : (
        <div>
          <h2 className="text-center">Number of Companies per Sector</h2>
          <Doughnut data={doughnutData} width={100} height={50} />
        </div>
      )}
    </div>
  );
};

export default Dashboard;
