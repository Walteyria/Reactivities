<script>
  import svelteLogo from './assets/svelte.svg'
  import axios from "axios";

  let activities = [];
  axios.get('http://localhost:5000/api/activities').then(response =>{
    activities = response.data;
    console.log(response.data)
  }, [])
</script>

<main>
  <div>
    <a href="https://vitejs.dev" target="_blank"> 
      <img src="/vite.svg" class="logo" alt="Vite Logo" />
    </a>
    <a href="https://svelte.dev" target="_blank"> 
      <img src={svelteLogo} class="logo svelte" alt="Svelte Logo" />
    </a>
  </div>
  <h1>Reactivities</h1>
  <ul>
    {#each activities as activity}
      <li>
        <p>
          {activity.title}
        </p>
      </li>
    {/each}
  </ul>
</main>

<style>
  .logo {
    height: 6em;
    padding: 1.5em;
    will-change: filter;
  }
  .logo:hover {
    filter: drop-shadow(0 0 2em #646cffaa);
  }
  .logo.svelte:hover {
    filter: drop-shadow(0 0 2em #ff3e00aa);
  }
</style>
