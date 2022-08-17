<script>
  import axios from "axios";
  import NavBar from "./NavBar.svelte";
  import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard.svelte";

  let activities = [];
  axios.get('http://localhost:5000/api/activities').then(response =>{
    activities = response.data;
  }, [])
  
</script>

<main>
  <NavBar/>
  <div class="container-sm">
    <ActivityDashboard activities={activities}/>
  </div>
</main>
